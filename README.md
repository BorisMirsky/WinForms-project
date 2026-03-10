# WinForms-project
CRUD operations on WinForms


### WinForms1 
1. Все CRUD операции работают.
2. Без ORM, запросы к БД напрямую (ADO.Net).
3. Пониженная версия System.Data.SQLite.
4. Не работает относительный путь, пришлось прописать абсолютный. 
5. В App.config добавить полный путь в БД к Database/ProductsAndCategories.db

---

### WinForms2
1. Пониженная версия Microsoft.EntityFrameworkCore.Sqlite.
2. Code First.
3. Все CRUD операции работают.
4. Работает без Fluent API Configuration - через заданный вручную bounding форм
   (файлы CategoryConfiguration.cs & ProductConfiguration.cs не нужны).
5. В App.config добавить свой полный путь в БД к Database/ProductsAndCategories.db




