Use AddScoped porque necesitamos crear una nueva instancia de StudentLogic por cada solicitud HTTP.
La instancia se crea al comienzo de la solicitud y se desecha al final.
Esto nos hace que cada solicitud tenga su propia instancia de StudentLogic, por lo que evitamos problemas de concurrencia cuando realizas muchas solicitudes y te asegura que los recursos se liberen correctamente cuando termina la solicitud.

