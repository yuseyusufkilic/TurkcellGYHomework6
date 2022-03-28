# TurkcellGYHomework6
 ASP.NET Core MVC, DI implementation methods were compared. For healthy comparising , GUID used. Observation have been made with it.
 

**Transient:** Application creates new instance for every request we do.

![transient](https://user-images.githubusercontent.com/79745654/160396532-c543b1a6-427d-4df0-98fa-fcebd6bc0280.JPG)


**Scoped:** Applicaton uses same instance for specific scope. It changes when the request refreshed.
![scoped](https://user-images.githubusercontent.com/79745654/160396826-9b47f070-8351-47f6-b849-64e6b8b745f0.JPG)


**Singleton:** Application creates one instance and uses it on everywhere. Instance remains same.
![singleton](https://user-images.githubusercontent.com/79745654/160397521-14719689-1927-4486-80d2-62489b4679f9.JPG)
