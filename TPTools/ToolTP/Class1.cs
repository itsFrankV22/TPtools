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
        public override string Description => "Teleports to the nearest player, NPC, or monster.";
        public override Version Version => new Version(1, 1);

        public NearestTP(Main game) : base(game)
        {
        }

        public override void Initialize()
        {
            Commands.ChatCommands.Add(new Command("tp.tool.tpplayer", NearestTPPlayerCommand, "playertp"));
            Commands.ChatCommands.Add(new Command("tp.tool.tpnpc", NearestTPNPCCommand, "npctp"));
            Commands.ChatCommands.Add(new Command("tp.tool.tpmonster", NearestTPMonsterCommand, "monstertp"));
        }

        private void NearestTPPlayerCommand(CommandArgs args)
        {
            var player = args.Player;

            if (!player.RealPlayer)
            {
                player.SendErrorMessage("No tienes permiso para usar este comando.");
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

        private void NearestTPNPCCommand(CommandArgs args)
        {
            var player = args.Player;

            if (!player.RealPlayer)
            {
                player.SendErrorMessage("No tienes permiso para usar este comando.");
                return;
            }

            var nearestNPC = Main.npc
                .Where(n => n.active && (n.friendly || n.townNPC))
                .OrderBy(n => Vector2.Distance(new Vector2(player.X, player.Y), new Vector2(n.position.X, n.position.Y)))
                .FirstOrDefault();

            if (nearestNPC == null)
            {
                player.SendErrorMessage("No se encontró ningún NPC cercano.");
                return;
            }

            player.Teleport(nearestNPC.position.X, nearestNPC.position.Y);
            player.SendSuccessMessage($"Te has teletransportado al NPC más cercano: {nearestNPC.FullName}.");
        }

        private void NearestTPMonsterCommand(CommandArgs args)
        {
            var player = args.Player;

            if (!player.RealPlayer)
            {
                player.SendErrorMessage("No tienes permiso para usar este comando.");
                return;
            }

            var nearestMonster = Main.npc
                .Where(n => n.active && !n.friendly && !n.townNPC)
                .OrderBy(n => Vector2.Distance(new Vector2(player.X, player.Y), new Vector2(n.position.X, n.position.Y)))
                .FirstOrDefault();

            if (nearestMonster == null)
            {
                player.SendErrorMessage("No se encontró ningún monstruo cercano.");
                return;
            }

            player.Teleport(nearestMonster.position.X, nearestMonster.position.Y);
            player.SendSuccessMessage($"Te has teletransportado al monstruo más cercano: {nearestMonster.FullName}.");
        }
    }
}
