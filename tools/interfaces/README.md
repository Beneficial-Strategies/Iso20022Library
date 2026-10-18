# Interface generator (#27)

`generate_interfaces.py --areas pacs [camt ...] [--partial]` writes, for every message of the business areas and every component and
choice they reach:

* the interface, in `src/BeneficialStrategies.Iso20022.Interfaces/` in the same folder layout (type documentation, `[IsoId]`, and for
  each member its documentation, `[IsoId]`, `[DisplayName]` and `[IsoXmlTag]`);
* a partial of the record next to it, `Name.Interfaces.cs`, that adds the interface and the explicit implementations C# needs where
  the record's member is a component, a choice or a list (`IEnumerable<IFoo> IBar.Items => Items;`).

`--partial` also makes the record declaration `partial`. The records are not otherwise changed. Run from the repository root, safe to repeat.

Interface members: get-only; required is not nullable and optional is; a member that may repeat is an `IEnumerable<T>`; a component or
choice member names the interface (`IFoo`, the choice `Foo_` is `IFoo`); a choice variant interface also derives from its choice's interface.
