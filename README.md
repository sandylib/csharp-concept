csharp-concept
==============

What is Polymorphism ?
*Polymorphisem allows you to invoke derived class methods through a base class reference during runtime.
*In the base class the method is declared virtual, and in the derived class we override the same method.
*The virtual keyword indicates,the method can be overridden in any derived class.

Delegates
*A delegate is a type safe function pointer.That is,it holds a reference(Pointer)to a function.
* 
* The signature of the delegate must match the signature of the function,
* the delegate points to,otherwise you get a compiler error.This is the 
* reason delegates are called as type safe function points.
* 
* A delegate is similar to a class. You can create an instance of it,
* and when you do so,you pass in the function name as a parameter to
* the delegate constructor,and it is to this function the delegate will point to.
* 
* Remember delegate syntax:Delegates syntax look very much similar to 
* a method with a delegate key keyword.

abstract
* The abstract keyword is used to create abstract classes.* 
* An abstract class is incomplete and hence can't be insatantiated. 
* An abstract class can only be used as base class. 
* An abstract class can't be sealed. 
* An abstract class may contain abstract members(methods,properties,indexers,and events),but not mandatory  
* A non-abstract class derived from an abstract class must provide implementations for all inherited abstract members. 
* If a class inherits an abstract class, there are 2 options available for that class
  *Option1:Provide implementation for all the abstract members inherited from the base abstract class. 
  * Option2:If the class does not wish to provide implementation for all the abstract members.inherited from the abstract class,then the class has to be marked as abstract.

Difference_between_classes_and_structs

* A struct is a value type where as a class is a reference type. 
* All the differences are applicable to value types and reference types are also applicable to classes and structs. 
* Structs are stored on stack, where as classes are stored on the heap. 
* Value types hold their value in memory where they are declared, but reference types hold a reference to an object in memory. 
* Value types are destroyed immediately after the scope is lost,where as for reference  types only the reference variable is destroyed after the scope is lost.The object
is later destroyed by garbage collector. 
* When you copy a struct into another struct, a new copy of that struct gets created and modifications on one struct will not affect the values contained by the other struct.
* When you copy a class into another class. we only get a copy of the reference variable.
* Both the reference variables point to the same object on the heap.Operations on one variable will affect the values contained by the other reference variable.
* Struct can't have destructors,but classes can have destructors. 
* Structs can't have explicit parameter less constructor but class can. 
* Struct can't inherit from another class but class can. 
* Both struts and classes can inherit from an interface.  
* Examples of structs in the .net framework -int(System.Int32),double(System.Double) etc. 
* class or struct can't inherit from another struct. Struct are sealed type.
* how do you prevent a class from being inherited? or what is the  significance of sealed  
* when a class marked as sealed then can't be use as base class

Difference_between_abstract_classes_and_interfaces
* Abstract classes can have implementation for some of its members(Methods),but the interface can't have implementation for any of its members. 
* Interfaces can't have fields where as an abstract class can have fields. 
* An interface can inherit from another interface only and can't inherit from an abstract class, where as an abstract class can inherit from abstarct class or another interface.
* A class can inherit from multiple interface at the same time,where as a class can't inherit from multiple classes at the same time. 
* Abstract class members can have access modifiers where as interface can't have access modifiers.

Multicast_Delegate

* A Multicast delegate is a delegate that has reference to more than one function.
* When you invoke a multicast delegate,all the functions the delegate is pointing to,
* are invoked.
* 
* There are 2 approaches to create a multicast delegate.Depending on the approach
* you use + or += to register a method with the delegate
* 
* - or -= to un-register a method with the delegate
* 
* A multicast delegate,invokes the methods in the invocation list,in the same
* order in which they are added.
* 
* If the delegate has a return type other than void and if the delegate is a 
* multicast delegate,only the value of the last invoked method will be returned.
* Along the same lines,if the delegate has an out parameter,the value of the 
* output parameter,will be the value assigned by the last method.
* 
* Where do you use multicast delegates?
* 
* Multicast delegate makes implementation of observed design pattem very simple.
* Observer pattem is also called as publish/suscribe pattem.

Function overloading and Method overloading terms are used interchangeabley.
 
* Method overloading allows a class to have multiple methods with the same name,
* but, with a different signature. So, in C# functions can be overloaded based on 
* the number,type(int,float etc) and kind(Value,Ref or Out) of parameters.
* 
* The signature of a method consists of the name of the method and the tye, kind(value,
* reference,or output) and the number of its formal parameters. The signature of a 
* method does not include the return type and the params modifier.So, it is not 
* possible to overload a function, just based on the return type or params modifier.

Interfaces

* We create interfaces using the interface keyword.Just like class interfaces also contains properties,
* methods,delegates or events,but only declarations and no implementations.
* 
* It is a compile time error to provide implementations for any interface member.
* 
* Interface members are public by default,and they don't allow explicit access modifies.
* 
* Interfaces cann't contain fields.
* 
* If a class or a struct inherits from an interface, it must provide implementation for all interface
* members.Otherwise we get a compiler error.
* 
* A class or a struct can inherit from more then one interface at the same time,but where as,
* a class can't inherit from more then once class at the same time.
* 
* Interfaces can inherit from other interfaces.A class that inherits this interface must 
* provide implementation for all interface members in the entire interface inheritance chain.
* 
* We can't create an instance of an interface,but an interface reference variable can 
* point to a derived class object.
* 
* Interface Naming Convention:Interface names are prefixed with capitalI.


