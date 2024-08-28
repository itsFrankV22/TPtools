using System;
using System.Linq;
using System.Numerics;
using Terraria;
using TerrariaApi.Server;
using TShockAPI;

namespace NearestTPPlugin
{
    [ApiVersion(2, 1)]
    public class NearestTP : TerrariaPlugin
    {
        public override string Name => "TPtool";
        public override string Author => "FrankV22";
        public override string Description => "Teleports to the nearest player.";
        public override Version Version => new Version(1, 0);

        public NearestTP(Main game) : base(game)
        {
        }

        public override void Initialize()
        {
            Commands.ChatCommands.Add(new Command("tp.tool.tpplayer", NearestTPCommand, "ntp"));
        }

        private void NearestTPCommand(CommandArgs args)
        {
            var player = args.Player;

            if (!player.RealPlayer)
            {
                player.SendErrorMessage("No tienes Permiso para usar este comando.");
                return;
            }

            var nearestPlayer = TShock.Players
                .Where(p => p != null && p.Active && p != player)
                .OrderBy(p => Vector2.Distance(new Vector2(player.X, player.Y), new Vector2(p.X, p.Y)))
                .FirstOrDefault();

            if (nearestPlayer == null)
            {
                player.SendErrorMessage("No se encontró ningún jugador cercano.");
                return;
            }

            player.Teleport(nearestPlayer.X, nearestPlayer.Y);
            player.SendSuccessMessage($"Te has teletransportado al jugador más cercano: {nearestPlayer.Name}.");
        }
    }
}