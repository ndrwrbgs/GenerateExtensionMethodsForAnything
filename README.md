You can achieve the same functionality with less code (though, losing the discoverability of extension methods) by
introducing a method as follows.

```Csharp
/// <summary>
///   Example usage:
///   <code>
///     string str = ...
///     var parsed = str.Wrap(double.Parse);
///   </code>
/// </summary>
public static TOut Wrap<TIn, TOut>(this TIn input, Func<TIn, TOut> projection)
{
	return projection(input);
)
```

Alternative names, per your liking:

`Select` - Benefit: in line with System.Linq namespace. Drawback: While select in query languages allows projection, it might sound like it's "selecting" a subset of attributes of the input, instead of modifying it completely

`Project` - Benefit: probably pretty accurate. Drawback: Very computer-sciency, rather than englishy

`Wrap` - Benefit: in cases where you are wrapping, very accurate. Drawback: In cases where you are 'selecting', inaccurate since you're not wrapping anything.
