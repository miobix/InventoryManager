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

## 230809
- Added a searchbox on Users - works with substrings using CONCAT on query string
- Created a PurchaseForm and AddPurchaseForm 
- A new Purchase must include the ID of the product and the user who made the purchase
- AddPurchaseForm displays the information from users and products
- Search function for both tables added
- ClickCell event autofills the AddPurchaseForm
- Cannot purchase more than available on inventory
- only INSERT operation implemented for now

## 230810
- Implemented LoadPurchases from database on initialization
- After completing a purchase, the remaining inventory amount is adjusted
- After deleting a purchase, restored item is added back to inventory
- Added a limit to purchase "negative" items
- Learned how to display date with a Custom format, on DataGridView and on a DatePicker element
- Implemented the login sequence
- To Fix: EDIT a purchase could not be implemented, it is commented out for now

#### Some pendings / ideas

- ~Check for duplicate password~
- Check for valid email format
- Display text correctly inside Edit and Delete buttons (currently not showing text) // replace for image?
- ~Check for empty strings when adding to the DB~
- ~Add a SearchBar for any list~
- (if possible) On UPDATE of a Category item, update the value of the corresponding Products
- Might need to separate Admin users from Customer users... maybe for next project?
