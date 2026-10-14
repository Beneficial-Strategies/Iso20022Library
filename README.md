# Beneficial Strategies ISO 20022 Monorepo

A family of .NET libraries for working with the [ISO 20022](https://iso20022.org) financial messaging standard. This library was built as part of developing and testing the [Beneficial Strategies ISO 20022 MCP Server](https://beneficialstrategies.com/product/mcp-server/) — a subscription SaaS product; its source is not released. This monorepo itself, however, is provided free of charge under a permissive license, and is expected to keep being updated as the ISO 20022 organization publishes new snapshots of the standard.

## Packages

| Package | Status | Description |
|---|---|---|
| [`BeneficialStrategies.Iso20022`](src/BeneficialStrategies.Iso20022.Common/README.md) | [Published](https://www.nuget.org/packages/BeneficialStrategies.Iso20022) | The full ISO 20022 message domain model — 3,339 message types as immutable, strongly-typed C# records, with XML and JSON serialization. |
| [`BeneficialStrategies.Iso20022.FluentValidation`](src/BeneficialStrategies.Iso20022.FluentValidation/README.md) | [Published](https://www.nuget.org/packages/BeneficialStrategies.Iso20022.FluentValidation) | FluentValidation validators enforcing ISO 20022 spec-level constraints the C# type system alone can't express. |
| [`BeneficialStrategies.Iso20022.MassTransit.Sagas`](src/BeneficialStrategies.Iso20022.MassTransit.Sagas/README.md) | Work in progress — not published | A MassTransit saga toolkit for ISO 20022 message flows (currently: Request-to-Pay). Investigative, not yet released. |

See each package's own README (linked above) for installation instructions and usage examples. For a full breakdown of ISO 20022 message coverage by business area, see [`doc/Scope-Statement.md`](doc/Scope-Statement.md).

## Help keep this library maintained

This library is free and permissively licensed, and it is **looking for support**. It has to follow every ISO 20022 snapshot (message sets, code sets, component changes), keep its validators in step, and answer the bug reports and requests that come with being used. That is a lot for a small team, and it is stronger with more people on it.

If your company builds on it, or you want to see an area kept up to date, there are several ways to help:

- **Sponsor or fund maintenance.** Write to [support@beneficialstrategies.com](mailto:support@beneficialstrategies.com) to talk about it.
- **Co-maintain an area.** The areas are the message model and serializers (`area:core`), the validators (`area:validation`) and the saga toolkit (`area:sagas`). Issues labelled [`maintainer-wanted`](https://github.com/Beneficial-Strategies/Iso20022Library/labels/maintainer-wanted) say where it would make the difference most.
- **Pick up an issue.** [`help wanted`](https://github.com/Beneficial-Strategies/Iso20022Library/labels/help%20wanted) and [`good first issue`](https://github.com/Beneficial-Strategies/Iso20022Library/labels/good%20first%20issue) are chosen to be doable without knowing the whole code base.
- **Bring real messages.** Valid, anonymised samples from your scheme turn into round-trip tests and decide which messages come next.
- **Report precisely.** A bug with a [failing unit test](CONTRIBUTING.md#reporting-a-bug) is usually fixed fastest.

See [CONTRIBUTING.md](CONTRIBUTING.md) for how issues and pull requests work, and [doc/Releasing.md](doc/Releasing.md) for how releases are made from them.

## License

Provided free of charge under a very non-restrictive license as a good-faith contribution to the community.

Questions or feedback? Reach us at [support@beneficialstrategies.com](mailto:support@beneficialstrategies.com).
