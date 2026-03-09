# WinForms-project
CRUD operations on WinForms


WinForms1 
1. CRUD работают.
2. Без ORM, запросы к БД напрямую (ADO.Net)
3. Пониженная версия System.Data.SQLite
4. Не работает относительный путь, пришлось прописать абсолютный. 



WinForms2
1. Пониженная версия Microsoft.EntityFrameworkCore.Sqlite
2. Code First
3. CRUD: Read, Update, Delete - ok

4.   ToDo:  
4.1  Create operation
Current Error:  SQLite Error 19: 'NOT NULL constraint failed: '
4.2  relative path?
4.2. Fluent API Configuration - не нужен?!
4.3  До нажатия кнопки остальные категории не отображаются


relative path?
string baseDir = AppDomain.CurrentDomain.BaseDirectory;
logFilePath = Path.Combine(baseDir, "C:\\TempServices\\CurrencyLog.txt");



