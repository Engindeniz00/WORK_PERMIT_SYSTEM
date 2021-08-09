# WORK_PERMIT_SYSTEM
 Here is a project that can manage permit system of employees.

# SQLite has implemented to project successfully
It took me 2 days to implement program corrently

# How does program works
You can easily restore datas which employee's permit date and time.
In addition, I made approve system. Let me explain with couple of examples:

Employee permissions : Can add order request and cancelation of work holidays leave requests

Chef permission : Can add order request and cancelation of work holidays leave requests. 
                  Can apply order which has been waiting for apply of Chef permission.
                  
Manager : Can add order request and cancelation of work holidays leave requests. 
          Can apply order which has been waiting for apply of Manager permission.
          In addition, can only see requests on table which is applied by Chef.
          
Deputy General Manager : Can add order request and cancelation of work holidays leave requests. 
                         Can apply order which has been waiting for apply of Manager permission.
                         In addition, can only see requests on table which is applied by Manager.
                         If Deputy General Manager applies the request which applied by Manager,
                         the request sign drop as APPLIED in Turkish 'Onayland' and shows in green 
                         color on table.
                         
Every member can cancel request unless it is applied. And it will show with red color on table.

# Here is the list of users and passwords
    User Name        Password
Engindeniz	Koçak -->  565400   (Employee)
Cooper	Curran  -->    565400   (Employee)
Sahara 	Brooks -->    920011   (Employee)
Eliana 	Wall -->      883023   (Employee)
Kerim	Tankurt -->     776552   (Manager)
Anastazja 	Kaiser --> 834822   (Chef)
Seb 	Pennington -->   922100   (deputy general manager)

# If you can use SQLite you can add Employee by manuelly 
You can find database file 


