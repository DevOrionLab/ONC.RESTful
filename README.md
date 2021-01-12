# ONC.RESTful.WebServices
## Descripción de la arquitectura 

La aplicación empresarial **ONC.RESTful.WebServices**, está proporcionadas en capas y contienen una gran variedad de proyectos de Visual Studio. Entonces, hay una breve descripción que explica para qué sirven cada carpeta y proyecto.


### Business
>Esta carpeta debe contener todos los proyectos y activos relacionados con la capa empresarial. Si tiene clases que solo se comparten entre los componentes de la capa empresarial, puede crear un proyecto **[ONC.RESTful.Business]**
Este proyecto debe contener todos los componentes principales del negocio. Las clases aquí deben contener toda la lógica de validación y procesamiento empresarial.

### Data
>Esta carpeta debe usarse para agrupar todos los proyectos y activos relacionados con la capa de datos. Cualquier clase que llame a servicios web externos o acceda a otro almacenamiento de datos, como el sistema de archivos, colas de mensajes, también debe ubicarse aquí. Si existen clases que solo se comparten entre componentes de la capa de datos, debe crear un proyecto **[ONC.RESTful.Data]** para mantenerlas aquí.

### Hosts
>Esta carpeta debe contener todos los proyectos de host que se implementarán en el servidor de aplicaciones. Puede crear tantos proyectos de host como sea necesario según sus necesidades de hosting.
**ONC.RESTful.Hosts**. Este proyecto debe contener todos los activos y la configuración para alojar el back-end de servicios en el servidor de aplicaciones. Este es el punto de entrada al servidor de aplicaciones.

### Presentation [Opcionales]
>Esta carpeta debe contener todos los proyectos y activos relacionados con la capa de presentación. Si tiene clases que solo se comparten entre los componentes de la capa de presentación, como el código de manipulación de elementos de la interfaz de usuario, puede crear un proyecto **[ONC.RESTful.UI]** para mantenerlas aquí.
**[Proyecto] .UI.Process** Este proyecto debe contener todos los componentes del proceso de la interfaz de usuario (o controladores). Las clases de sesión, gestión de estado y control de página también deberían residir aquí.
**[Proyecto] .UI.Web** Este proyecto debe contener todas las páginas, los scripts y los recursos de la interfaz de usuario que se implementarán en el servidor web. Este es el principal punto de entrada a la aplicación web en capas.


### Services
>Esta carpeta debe agrupar todos los proyectos y activos relacionados con la capa de servicio. Todo el código relacionado con los servicios, ya sean ASMX, WCF o API WEB (REST), deben residir en esta carpeta. Si tiene algún proyecto que amplíe las capacidades de la tecnología de servicio, también debe residir en esta carpeta.
**[Proyecto] .Services.Contracts**  Este proyecto debe contener todos los servicios y contratos de mensajes para los servicios WCF. Para servicios que no son de WCF, este proyecto puede servir para contener clases contenedoras para clases de mensajes de solicitud y respuesta que se usan para la comunicación.
**[Proyecto] .Services.Http** Este proyecto debe contener todas las clases de implementación de servicios relacionados con la API WEB de ASP .NET.

### Shared
> Esta carpeta contiene todos los proyectos y activos que se pueden compartir entre cualquiera de los proyectos en las capas.
**[Proyecto]. Entities**: Este proyecto debe contener todas las clases de entidad que se comparten entre todos los demás proyectos de la capa.
**[Proyecto].Framework**: Este proyecto debe contener todos los componentes transversales, como autenticación, autorización, auditoría, registro, configuración, etc.

## Arquitectura general
![enter image description here](https://github.com/DevOrionLab/ONC.RESTful/blob/main/_lasg.settings/Architecture-v1.png)

### Ejemplos desde Swagger UI - ONC

Llama al método de negocio Find de FrenteObraComponent, el cual a través del estado y el numero retornan el FrenteObraGetEstadoNumero. Por ejemplo:

|                |SERVICIO                         |PARÁMETROS                   |
|----------------|---------------------------------|-----------------------------|
|GET             |`GetFrenteObraByEstadoAndNumero` | {estado}/{numero}           |
|estado          |`numérico` requerido             | Estado del Frente de Obra   |
|numero          |`alfanumérico ` requerido        | Número del Frente de Obra   |

>Request URL
http://host/api/Obra/GetFrenteObraByEstadoAndNumero/3/COD4785

### Response Messages
| HTTP Status Code | Reason                  |
|------------------|-------------------------|
|400               |Bad request              |
|422               |Unprocessable Entity     |
|500               |Internal Server Error   |
