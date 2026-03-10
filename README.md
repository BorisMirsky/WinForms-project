# WinForms-project
CRUD operations on WinForms


### WinForms1 
1. CRUD операции работают.
2. EF установлен, но запросы к БД идут напрямую (ADO.Net).
3. Пониженная версия System.Data.SQLite.
5. В App.config добавить свой полный путь к БД 'Database/students_db.db'.

---

### WinForms2
1. Пониженная версия Microsoft.EntityFrameworkCore.Sqlite.
2. Code First.
3. CRUD операции работают.
4. Работает без Fluent API Configuration - через заданное связывание форм
   (т.е. файлы CategoryConfiguration.cs & ProductConfiguration.cs не нужны).
5. В App.config добавить свой полный путь к БД 'Database/ProductsAndCategories.db'.




