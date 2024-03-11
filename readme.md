Patrones de diseño aplicados a C#

- Patrones creacionales:

1) - Factory method:

- Proporciona una interfaz para crear objetos en una superclase, mientras permite a las subclases alterar el tipo de objetos que se crearan (Separa la creación de la lógica).
- Se compone de 4 elementos:
- El producto: Es la interfaz común a todos los objetos que puede producir la clase creadora y sus subclases.
- Los productos concretos: Son las distintas implementaciones de la interfaz del producto.
- La clase creadora: Declara el método de fábrica que devuelve nuevos objetos de productos concretos (El tipo de retorno debe coincidir con la interfaz del producto).
- Las creadores concretas: Sobrescriben la clase creadora, devolviendo un producto concreto.

2) - Abstract Factory:

- Nos permite producir familias de objetos relacionados, sin especificar sus clases concretas.
- Declaramos de forma explicita interfaces para cada producto diferente de la familia de productos (Por ejemplo: Silla, Sofa, etc).
- Luego definimos que todas las variantes de productos sigan esas interfaces (Silla moderna, Silla minimalista, etc).
- Se define la fábrica abstracta: Una interfaz con una lista de métodos de creación, para todos los productos que son parte de la familia de productos.
- Creamos las clases concretas para cada variable diferente de familias de productos, basada en la interfaz.
