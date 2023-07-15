using AnonymousMethods; 

List<int> numList = new List<int>() { 2, 3, 5 };
WorkBench.Calculator(numList);


/*
 
An anonymous method is inline unnamed method in the code. It is created using the delegate keyword and doesn’t require a name and return type. 
Hence we can say, an anonymous method has the only body without a name, optional parameters and return type. 
An anonymous method behaves like a regular method and allows us to write inline code in place of explicitly named methods.

A variable declared outside the anonymous method can be accessed inside the anonymous method.

A variable declared inside the anonymous method can’t be accessed outside the anonymous method.

We use an anonymous method in event handling.
 
An anonymous method declared without parenthesis can be assigned to a delegate with any signature.

The unsafe code can’t be accessed within an anonymous method.

An anonymous method can’t access the ref or out parameters of an outer scope.

 */

/* 
  
İsimsiz metod kullanımının amacı ise sadece bir kere kullanılacak, tekrar kullanımı gerekmeyecek metodları 
satır içinde (inline-code) daha pratik bir biçimde yazabiliyor olmaktır. Event'lerde ve arayüz uygulamalarında daha sık kullanılmaktadır.

 */