1. About 2 hours. I would like to add logging system and better excption handling for edge cases. Create unit test for edge cases.

2. As of C# 9 there is an option added for checking null object with "is" and "is not" key word following by "{}" representing if the object is null or not, which is a cool feature. 

for example:
<pre>
<code>
 if (user is { })
 {
     //your code goes here...
 }
 or 
 if (user is not { })
 {
     //your code goes here...
 }
</code>
</pre>
Another feature added to C#9 is immutable recods.
<pre>
<code>
  public record Person
  {
      public string FirstName { get; set; }
      public string LastName { get; set; }
  };
</code>
</pre>

3. For tracking performance issues in my backend project I use prometeus monitoring which is a greate library for tracking performance and latency of a api request and with grafana dashboard on to p of it you can easily see whats going on in your production project!
For mobile application like android or IOS  Firebase offers a feature called performance to track application performance issue like api call latencis for various phone manufactures.
For query performance issues I use profiler to see how ORM generate sql query and then optimize it.

4. Overally it is a simple and good example for checking my ability for work with 3rd party libraris which is I think, extensivly use in your your project.
