The Asset comes pre-made. There is no need to add scripts to game objects in the Hierarchy.

HIERARCHY:

There are 2 important objects in the Hierarchy window:
1- 'Canvas / Inventory' object. Through it you will make the necessary changes depending on the needs of your project.
2- 'Cursor' object. The object itself has a custom pointer sprite. Inside it there is an object called 'CursorItemImg' that has the function of becoming the image of the selected item in the UI.

Within the 'Canvas / Inventory / UiSlots' object are the buttons that represent the item slots. You can add more or remove them.

The 'Canvas / Inventory / DropSpaceBtn' object is a button that is VISIBLE, but can very well be changed to be invisible to the player's eyes and have a larger area if needed. (Image.color.alpha)

The 'Canvas / Inventory / CollectItemBtn' object is a SIMULATION of the player collecting a new item. You can add a new item any way you want.

INSPECTOR:

The only Inspector window that exists is located on the 'Canvas / Inventory' object. Place the mouse over all the variables shown to get tips and guidelines (tooltips)

SCRIPT:

There are 3 scripts in this Asset:

1- Item: Responsible for the main characteristics of each game item. You can modify these characteristics.

2- ItemDatabase: Responsible for creating the ScriptableObject, serving as a database of all items in your game. Go to 'Assets / Fast Inventory System / DAO / ItemDatabase' and add all items with their information. Remembering that the variable 'id' needs to be filled with a unique value for each item in your project.

3- InventoryUISystem: Responsible for all code related to the use of Asset. Add, remove, relocate and stake items. In addition to functions designed to help the life of the developer.

DEVELOPER:

Within the 'InventorySystemUI' class.

You need to DELETE last REGION from this script: #region DELETE THIS FUNCTION
This region is used to generate random items inside bag by clicking on 'Collect Item' button from the UI
This button was built only for demonstration purposes!

Some functions that can help you:
 public void AddItem(Item capturedItemByTrigger) //404
 public List <Item> ReturnBagItems () // line 410
 public int SearchForItemInBagItems (int itemId) // line 415
 public int UseItem (Transform value) // line 422
 public void DeleteItem (int idx) // line 432

 #END