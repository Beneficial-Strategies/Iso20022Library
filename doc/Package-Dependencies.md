# Package dependencies

> Draft, read from the project files of this repository (`src/*/*.csproj`) as of `main` after #89. An arrow means "references".

The packages form a small tree with one root (`Primitives`) and one deliberate split: the **interfaces** of the model (`Interfaces`) are separate from the **records** that implement them (`Common`). Everything that works on messages (validators, payload validation, the factory, the samples, the sagas) is written against the interfaces, so none of it references `Common`.

## The packages

```mermaid
flowchart BT
    classDef std fill:#e8f1fb,stroke:#3b7dd8,color:#0b2a4a
    classDef net fill:#fdf1e3,stroke:#d98a2b,color:#4a2c05
    classDef wip stroke-dasharray: 5 3

    P["<b>Primitives</b><br/>simple types, code sets, amounts,<br/>serializers, IIsoDataFactory"]:::std

    I["<b>Interfaces</b><br/>an interface for every message,<br/>component and choice"]:::std
    C["<b>Common</b> (the records)<br/>3,339 messages: the model<br/>that implements the interfaces"]:::net

    V["<b>FluentValidation</b><br/>validators of the interfaces"]:::std
    X["<b>FluentValidation.Xml</b><br/>validate XML text, documents, elements"]:::std
    PL["<b>FluentValidation.Payloads</b><br/>validate raw XML / JSON payloads"]:::std
    F["<b>Factory</b><br/>classes for the interfaces,<br/>built at run time"]:::std
    S["<b>Samples</b><br/>named valid / invalid objects"]:::std
    M["<b>MassTransit.Sagas</b><br/>Request-to-Pay sagas<br/>(not published)"]:::net

    I --> P
    C --> P
    C --> I
    V --> P
    V --> I
    X --> P
    PL --> P
    PL --> X
    F --> P
    S --> P
    S --> I
    S --> F
    M --> I
```

| Colour | Targets |
|---|---|
| blue | `netstandard2.0`, `net8.0`, `net10.0` (usable from .NET Framework 4.6.1+, Mono and Unity) |
| orange | `net8.0`, `net10.0` only |

## What each one brings in besides the packages above

```mermaid
flowchart LR
    classDef pkg fill:#e8f1fb,stroke:#3b7dd8,color:#0b2a4a
    classDef ext fill:#f3f3f3,stroke:#888,color:#222

    P[Primitives]:::pkg --> STJ[System.Text.Json]:::ext
    P --> DO[Portable.System.DateTimeOnly<br/>netstandard2.0 only]:::ext
    P --> HC[Microsoft.Bcl.HashCode<br/>netstandard2.0 only]:::ext

    V[FluentValidation pkg]:::pkg --> FV[FluentValidation 11]:::ext
    V --> FVDI[FluentValidation.DependencyInjectionExtensions 11]:::ext
    X[FluentValidation.Xml]:::pkg --> FV
    PL[FluentValidation.Payloads]:::pkg --> FV
    PL --> DIA[Microsoft.Extensions.DependencyInjection.Abstractions 8]:::ext

    F[Factory]:::pkg --> DIA
    F --> HA[Microsoft.Extensions.Hosting.Abstractions 8]:::ext
    F --> EM[System.Reflection.Emit 4.7<br/>netstandard2.0 only]:::ext

    M[MassTransit.Sagas]:::pkg --> MT[MassTransit 8.x<br/>Apache-2.0]:::ext
```

(`Polyfill` is a build-time-only dependency of the `netstandard2.0` builds and is not listed. Every package listed is MIT, Apache-2.0, BSD or ISC; `tools/licenses/check.sh` enforces it for the published projects.)

## Choosing what to install

| I want to... | Install | Not needed |
|---|---|---|
| Use the primitive types and code sets, or read/write the serializer formats | `Primitives` | everything else |
| Program against message shapes with a class of my own | `Interfaces` | `Common` |
| Work with the ready-made message records (and their XML / JSON) | `Common` (brings `Interfaces`, `Primitives`) | |
| Validate messages | `FluentValidation` | `Common` |
| Validate XML or JSON text without writing a class for it | `FluentValidation.Payloads` (brings `.Xml`) | `Common`, `Interfaces` |
| Read a message without the records | `Factory` (+ `Interfaces` for the shapes) | `Common` |
| Write tests that need valid objects | `Samples` (brings `Factory`, `Interfaces`) | `Common` |
| Run the Request-to-Pay sagas on MassTransit | `MassTransit.Sagas` (not published) + `Factory` in your app | `Common` |

## The same, for the tests of this repository

Not part of the packages; shows which test projects still need `Common`: only `Common.Tests` should, and `Xml.Tests` and `Payloads.Tests` until their tests move onto the samples (#88).

```mermaid
flowchart LR
    classDef t fill:#f6f0fa,stroke:#8a5cc2,color:#2a1245
    classDef pkg fill:#e8f1fb,stroke:#3b7dd8,color:#0b2a4a
    classDef net fill:#fdf1e3,stroke:#d98a2b,color:#4a2c05

    PT[Primitives.Tests]:::t --> P[Primitives]:::pkg
    CT[Common.Tests]:::t --> C[Common]:::net
    VT[FluentValidation.Tests]:::t --> V[FluentValidation]:::pkg
    VT --> F[Factory]:::pkg
    VT --> S[Samples]:::pkg
    NST[FluentValidation.NetStandard.Tests]:::t --> V
    NST --> X[FluentValidation.Xml]:::pkg
    NST --> PL[FluentValidation.Payloads]:::pkg
    NST --> F
    NST --> I[Interfaces]:::pkg
    XT[FluentValidation.Xml.Tests]:::t --> X
    XT --> V
    XT --> F
    XT --> C
    PLT[FluentValidation.Payloads.Tests]:::t --> PL
    PLT --> V
    PLT --> F
    PLT --> C
    FT[Factory.Tests]:::t --> F
    FT --> V
    FT --> S
    MT[MassTransit.Sagas.Tests]:::t --> M[MassTransit.Sagas]:::net
    MT --> F
```

`Xml.Tests` and `Payloads.Tests` still build the same pacs.029 message with the records; the samples for it exist now, so the next change moves them over. `Factory.Tests` no longer references `Common`: what the records write (XML and JSON) is kept in it as fixed text.

## Rules the diagram encodes

1. **`Primitives` references nothing of ours.** Everything else reaches it.
2. **Only `Common` references the records' side of the model;** nothing else may. `Payloads`, `Factory` and the sagas each have a test that their assembly does not reference `Common`.
3. **`Interfaces` and `Common` share their namespaces** (`Components`, `Choices`, one per message area); a caller sees one model.
4. **`FluentValidation.Xml` does not reference `Interfaces`:** it is generic over the type it is given. `Payloads` builds on `Xml`.
5. **`Samples` references `Factory`** (it builds objects with it); `Factory` knows nothing of `Samples`.

## Open points

* **Published or not:** the root README lists `Common`, `Primitives` and `FluentValidation` as published; `Interfaces`, `.Xml`, `.Payloads`, `Factory` and `Samples` are packable and wired into `publish.yml` and the license check, but I have not checked which are on NuGet today; the sagas are not published. The diagram does not show this; say if it should (a fourth colour).
* **Namespaces:** the CLR namespaces cross these package boundaries (`Validation.*` spans three packages); the proposed standard is #83.
