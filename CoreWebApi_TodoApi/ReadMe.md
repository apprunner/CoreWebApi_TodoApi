 Employee種子資料 + IRepository -> EmployeeRepository + DI :
 (1)以Migration建立Employee種子資料
 (2)建立IRepository -> EmployeeRepository,建立一個EF讀取所有員工資料的方法
 (3)以DI註冊IRepository ,EmployeeRepository
 (4)建立EmployeesController API控制器, 建立GET方法,以DI注入IRepository,然後顯示所有員工資料
