# TPtool - Plugin de Teletransportación Cercana

**Versión:** 1.1  
**Autor:** FrankV22  
**Descripción:** Un plugin de Terraria que permite a los jugadores teletransportarse al jugador, NPC o monstruo más cercano.

## Tabla de Contenidos

- [Introducción](#introducción)
- [Características](#características)
- [Instalación](#instalación)
  - [Comandos](#comandos)
  - [Permisos](#permisos)

## Introducción

**TPtool** es un plugin simple pero potente para servidores de Terraria que ejecutan TShock. Permite a los jugadores teletransportarse al jugador, NPC o monstruo más cercano con facilidad. Esto puede ser especialmente útil en mundos grandes donde encontrar otros jugadores o NPCs específicos puede ser un desafío. Utilizando los comandos proporcionados, los jugadores pueden localizar y teletransportarse rápidamente a las entidades cercanas, mejorando su experiencia de juego.

## Características

- **Teletransportarse al jugador más cercano**: Encuentra y teletransporta rápidamente al jugador activo más cercano.
- **Teletransportarse al NPC más cercano**: Encuentra y teletransporta al NPC más cercano, incluidos NPCs amistosos y de pueblo.
- **Teletransportarse al monstruo más cercano**: Localiza y teletransporta al monstruo hostil más cercano.

## Instalación

1. **Descargar el Plugin**: Descarga el DLL compilado de TPtool desde la sección de [Releases](#) de este repositorio.
2. **Mover a la Carpeta de Plugins de TShock**: Coloca el archivo `TPtool.dll` en la carpeta `ServerPlugins` de tu instalación de TShock.
3. **Reiniciar el Servidor**: Reinicia tu servidor de TShock para cargar el nuevo plugin.

### Comandos

Los siguientes comandos están disponibles en TPtool:

| Comando     | Descripción                                           | Ejemplo de Uso   |
|-------------|-------------------------------------------------------|------------------|
| `/playertp` | Teletransporta al jugador al jugador más cercano.     | `/playertp`      |
| `/npctp`    | Teletransporta al jugador al NPC amistoso o de pueblo más cercano. | `/npctp`       |
| `/monstertp`| Teletransporta al jugador al monstruo hostil más cercano. | `/monstertp`   |

### Permisos

Para controlar el acceso a cada comando, TPtool utiliza permisos específicos:

| Permiso               | Descripción                                      |
|-----------------------|--------------------------------------------------|
| `tp.tool.tpplayer`    | Permite teletransportarse al jugador más cercano.|
| `tp.tool.tpnpc`       | Permite teletransportarse al NPC más cercano.    |
| `tp.tool.tpmonster`   | Permite teletransportarse al monstruo más cercano.|
