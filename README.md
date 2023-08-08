# InventoryManager
CRUD operations with WinForms

## Init

### Draw Forms
- Login
- Main Menu
- User List
- Add new user

### Database Connection
- Can Add a new record to local MySQL database
- generate a unique user ID on Insert

## 230804
- Load userlist from DB, display on DataGridView
- Display a child Form inside another Form
- Navigation added to some buttons, "Add New User"
- Edit and Delete entries added to the User List

## 230807
- Added password check on Add New User
- Replicated User CRUD operations for Categories menu
- Can create, edit and delete entries
- ~The Form is on an infinite loop for an unidentified reason. In Debugging.~

## 230808
- Fixed Loading issue on CategoryForm
- Added Forms for Product List and Add New Product
- Replicated CRUD operations for Products menu
- Limited the Category property of new products to only the categories previously registered on the system 
- Checked the order the input fields move into when pressing TAB
- Changed the handling of "Cancel" button on PopUps from this.Close() to this.Dispose()
- Added a sample database to use when cloning the code

#### Some pendings / ideas

- ~Check for duplicate password~
- Check for valid email format
- Display text correctly inside Edit and Delete buttons (currently not showing text)
- Check for empty strings when adding to the DB
- Add a SearchBar for any list
- (if possible) On UPDATE of a Category item, update the value of the corresponding Products
