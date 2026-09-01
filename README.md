# Beneficial Strategies ISO 20022 Monorepo

A family of .NET libraries for working with the [ISO 20022](https://iso20022.org) financial messaging standard. This library was built as part of developing and testing the [Beneficial Strategies ISO 20022 MCP Server](https://beneficialstrategies.com/product/mcp-server/) — a subscription SaaS product; its source is not released. This monorepo itself, however, is provided free of charge under a permissive license, and is expected to keep being updated as the ISO 20022 organization publishes new snapshots of the standard.

## Packages

| Package | Status | Description |
|---|---|---|
| [`BeneficialStrategies.Iso20022`](src/BeneficialStrategies.Iso20022.Common/README.md) | [Published](https://www.nuget.org/packages/BeneficialStrategies.Iso20022) | The full ISO 20022 message domain model — 3,311 message types as immutable, strongly-typed C# records, with XML and JSON serialization. |
| [`BeneficialStrategies.Iso20022.FluentValidation`](src/BeneficialStrategies.Iso20022.FluentValidation/README.md) | [Published](https://www.nuget.org/packages/BeneficialStrategies.Iso20022.FluentValidation) | FluentValidation validators enforcing ISO 20022 spec-level constraints the C# type system alone can't express. |
| [`BeneficialStrategies.Iso20022.MassTransit.Sagas`](src/BeneficialStrategies.Iso20022.MassTransit.Sagas/README.md) | Work in progress — not published | A MassTransit saga toolkit for ISO 20022 message flows (currently: Request-to-Pay). Investigative, not yet released. |

See each package's own README (linked above) for installation instructions and usage examples. For a full breakdown of ISO 20022 message coverage by business area, see [`doc/Scope-Statement.md`](doc/Scope-Statement.md).

## License

Provided free of charge under a very non-restrictive license as a good-faith contribution to the community.

Questions or feedback? Reach us at [support@beneficialstrategies.com](mailto:support@beneficialstrategies.com).
