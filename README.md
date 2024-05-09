# SimpleRPG

Trying to make simple RPG using WinForms
You can try to create your own plot, using my ready code

## 3 Base structures (classes):

### RPGMap
Container for game objects.
You can draw all of your objects on screen, using static class MapDrawer and method Draw.
Example of creating:
```csharp
md = new MapDrawer(3, 3, 50, this);
// Arguments:
// 1, 2 - (rows, cols), map size
// 3 - cell size
// 4 - Form, where you will want to see map

map = new RPGMap(md);
// Argument: out MapDrawer
```


### RPGObject
Game objects, those you can see on map.
Some game objects types (You can add own):

#### `RPGStatic`
Static objects, for example: tree, rock.

#### `RPGResource`
Static, same as RPGStatic, but you can earn some resources from it.

#### `RPGInteractic`
Objects, which you can interact, for example: chest.

#### `RPGEntity`
Live creatures, which have health, inventory and right hand (only).

#### `RPGNPC`
NPCes.

### RPGItem
Game items, there are some types too (and you can add own):

#### `RPGUsable` 
Items, which you can use by taking in right hand and clicking 'space', if it is player.

#### `RPGComponent`
Items, which will be use in crafts.

### Ready:
- Player (can move, interact, use items in right hand)
- Chests (you can put in some resources)
- Tab Menu (inventory and craft (but crafting not work for now))
- MapDrawer (draws objects on screen, and dont flashing like before)
- Crafting System
- Simple Dialogue and Speech window

