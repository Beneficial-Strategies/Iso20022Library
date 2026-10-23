# Beneficial Strategies ISO 20022 (the remains of the monorepo)

A family of .NET libraries for working with the [ISO 20022](https://iso20022.org) financial messaging standard. **Each package is moving to a repository of its own; this one still holds the validators, the samples and the saga toolkit** (see the table). This library was built as part of developing and testing the [Beneficial Strategies ISO 20022 MCP Server](https://beneficialstrategies.com/product/mcp-server/) — a subscription SaaS product; its source is not released. This monorepo itself, however, is provided free of charge under a permissive license, and is expected to keep being updated as the ISO 20022 organization publishes new snapshots of the standard.

## Packages

| Package | Status | Description |
|---|---|---|
| `BeneficialStrategies.Iso20022` | **Deprecated** (last version 0.7.0-alpha) | Replaced by `BeneficialStrategies.Iso20022.Messages.Records` (the same namespaces; only the package reference changes). |
| [`BeneficialStrategies.Iso20022.Messages.Records`](https://github.com/Beneficial-Strategies/iso-20022-messages-records) | Published, from its own repository | The records of every ISO 20022 message, component and choice, written at compile time by a source generator from the interfaces: immutable, compared by value, read and written as XML and JSON. |
| [`BeneficialStrategies.Iso20022.Primitives`](https://github.com/Beneficial-Strategies/iso-20022-primitives) | [Published](https://www.nuget.org/packages/BeneficialStrategies.Iso20022.Primitives) | The ISO 20022 primitive data types, code sets and external codes with their format validation and JSON converters, without the message records. `BeneficialStrategies.Iso20022` depends on it. |
| [`BeneficialStrategies.Iso20022.Messages`](https://github.com/Beneficial-Strategies/iso-20022-messages) | Published, from its own repository | An interface for every ISO 20022 message, component and choice, so a class of your own can stand in for a record. Implemented by the records of `BeneficialStrategies.Iso20022.Messages.Records`. |
| [`BeneficialStrategies.Iso20022.Factory`](https://github.com/Beneficial-Strategies/iso-20022-factory) | Published, from its own repository | Objects for the interfaces, made for you at run time: ask for an interface and the Factory builds a class that implements it and fills it from XML or JSON, so no implementation library is needed. |
| [`BeneficialStrategies.Iso20022.FluentValidation`](src/FluentValidation/README.md) | [Published](https://www.nuget.org/packages/BeneficialStrategies.Iso20022.FluentValidation) | FluentValidation validators enforcing ISO 20022 spec-level constraints the C# type system alone can't express. |
| [`BeneficialStrategies.Iso20022.FluentValidation.Xml`](src/FluentValidation.Xml/README.md) | In preparation | Read ISO 20022 XML into an object and validate it in one call: the populated object, or every problem found with the path of its element, as ordinary FluentValidation failures. |
| [`BeneficialStrategies.Iso20022.FluentValidation.Payloads`](src/FluentValidation.Payloads/README.md) | In preparation | Validate raw ISO 20022 XML or JSON text as it arrives (a queue, an HTTP body, a file); a payload that cannot be read comes back as validation failures, not an exception. |
| [`BeneficialStrategies.Iso20022.Messages.Samples`](https://github.com/Beneficial-Strategies/iso-20022-messages-samples) | [Published](https://www.nuget.org/packages/BeneficialStrategies.Iso20022.Messages.Samples), from its own repository | Named, valid ISO 20022 objects for tests, and a generated minimal valid object for any interface, built through the `Factory` against the interfaces, so a test needs no message records. |
| [`BeneficialStrategies.Iso20022.MassTransit.Sagas`](src/MassTransit.Sagas/README.md) | Work in progress — not published | A MassTransit saga toolkit for ISO 20022 message flows (currently: Request-to-Pay). Investigative, not yet released. |

How the packages depend on one another, and which to install for what, is in [doc/Package-Dependencies.md](doc/Package-Dependencies.md).

The samples are in their own repository, [iso-20022-messages-samples](https://github.com/Beneficial-Strategies/iso-20022-messages-samples); the standard they follow (where a sample lives, `Minimal` and `Maximal`, a new object on each access) is in its README. Whether every generated `Minimal` sample is valid is checked here, by the validators (`src/FluentValidation.Tests/Samples`).

See each package's own README (linked above) for installation instructions and usage examples. For a full breakdown of ISO 20022 message coverage by business area, see [`doc/Scope-Statement.md`](doc/Scope-Statement.md).

## Help keep this library maintained

This library is free and permissively licensed, and it is **looking for support**. It has to follow every ISO 20022 snapshot (message sets, code sets, component changes), keep its validators in step, and answer the bug reports and requests that come with being used. That is a lot for a small team, and it is stronger with more people on it.

If your company builds on it, or you want to see an area kept up to date, there are several ways to help:

- **Sponsor or fund maintenance.** Write to [support@beneficialstrategies.com](mailto:support@beneficialstrategies.com) to talk about it.
- **Co-maintain an area.** The areas are the message model and serializers (`area:core`), the primitive types and code sets (`area:primitives`), the interfaces (`area:interfaces`), the validators (`area:validation`), the payload validators (`area:payloads`), the validation from XML (`area:xml`), the run-time implementations of the interfaces (`area:factory`), the sample objects for tests (`area:samples`) and the saga toolkit (`area:sagas`). Issues labelled [`maintainer-wanted`](https://github.com/Beneficial-Strategies/Iso20022Library/labels/maintainer-wanted) say where it would make the difference most.
- **Pick up an issue.** [`help wanted`](https://github.com/Beneficial-Strategies/Iso20022Library/labels/help%20wanted) and [`good first issue`](https://github.com/Beneficial-Strategies/Iso20022Library/labels/good%20first%20issue) are chosen to be doable without knowing the whole code base.
- **Bring real messages.** Valid, anonymised samples from your scheme turn into round-trip tests and decide which messages come next.
- **Report precisely.** A bug with a [failing unit test](CONTRIBUTING.md#reporting-a-bug) is usually fixed fastest.

See [CONTRIBUTING.md](CONTRIBUTING.md) for how issues and pull requests work, and [doc/Releasing.md](doc/Releasing.md) for how releases are made from them.

## License

Provided free of charge under a very non-restrictive license as a good-faith contribution to the community.

**ISO 20022 material.** The ISO 20022 specification, its schemas, code sets and their text are ISO's. ISO and its Registration Authority publish them to be used and reproduced freely under the [ISO 20022 Terms of use](https://www.iso20022.org/terms-use) and the [Intellectual Property Rights Policy](https://www.iso20022.org/intellectual-property-rights). **This is not the official ISO 20022 site. The sole source of up-to-date material is <https://www.iso20022.org/>.** ISO's material is provided "as is", without warranty. The license of this repository covers what we wrote, not ISO's material. This is not legal advice.

Questions or feedback? Reach us at [support@beneficialstrategies.com](mailto:support@beneficialstrategies.com).
