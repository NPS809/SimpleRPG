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
It has 3 fields peculiar only to him.
```csharp
int current_health;
int max_health;
RPGItem finite_resource; // Resource, that will be drop from your object
```

#### `RPGInteractic`
Objects, which you can interact, for example: chest.

`OnInteract` method, which takes 2 argument:
```csharp
abstract void OnInteract(RPGEntity interacter, RPGMap map);
```

#### `RPGEntity`
Live creatures, which have health, inventory and right hand (only).
Parent of all creatures.
```csharp
int current_health;
int max_health;
RPGUsable? right_hand;
List<RPGItem> inventory;
```

#### `RPGNPC`
NPCes.
It is child of RPGEntity, but has OnInteract method, same as a RPGInteractic's

### RPGItem
Game items, there are some types too (and you can add own):

By default, it has name and count (and description, but it is not matter)

Important, his every child must has `Copy` method. 

#### `RPGUsable` 
Items, which you can use by taking in right hand and clicking 'space', if it is player.

It has method `OnUse`:
```csharp
abstract void OnUse(RPGEntity user, RPGMap map);
```

#### `RPGComponent`
Items, which will be use in crafts.

### Ready:
- Player (can move, interact, use items in right hand)
- Chests (you can put in some resources)
- Tab Menu (inventory and craft (but crafting not work for now))
- MapDrawer (draws objects on screen, and dont flashing like before)
- Crafting System
- Simple Dialogue and Speech window

