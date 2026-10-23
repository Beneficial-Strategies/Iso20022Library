# BeneficialStrategies.Iso20022

The ready-made C# classes for **every ISO 20022 message**: 3,339 financial-services messages, and every component and choice they are made of, as immutable records with XML and JSON serialization.

Each record **implements the interface of its shape** (from [BeneficialStrategies.Iso20022.Messages](https://www.nuget.org/packages/BeneficialStrategies.Iso20022.Messages)), and the interfaces are what the rest of the family is built on. So a record from this package works with the validators, the readers and everything else, and when you do not want 3,339 messages' worth of classes, the same tools work with classes you write or have made for you. See [Where the records fit](#where-the-records-fit) at the end. The records are built from [the primitive types](https://www.nuget.org/packages/BeneficialStrategies.Iso20022.Primitives), strongly typed all the way down, so dirty data that does not fit the ISO 20022 specification cannot get into your system through them in the first place.

This library was built as part of developing and testing the [Beneficial Strategies ISO 20022 MCP Server](https://beneficialstrategies.com/product/mcp-server/), a subscription SaaS product; its source is not released. This library itself, however, is provided free of charge under a permissive license, and is expected to keep being updated as the ISO 20022 organization publishes new snapshots of the standard.

## Let's talk why

[ISO20022](https://iso20022.org) is fast becoming the defacto [inter-partner financial communication language](https://businesspaymentscoalition.org/wp-content/uploads/0217-bpc-intro-iso20022.pdf) for sending financial information. It is being [adopted in the US](https://businesspaymentscoalition.org/wp-content/uploads/0517-us-adoption-iso20022.pdf) and also [being adopted world-wide](https://medium.datadriveninvestor.com/world-digital-currencies-are-already-here-cbdcs-bc756bd899b9).
It's not just for banks any more. Experts are encouraging corporations to hasten with a [migration strategy](https://blogs.opentext.com/what-does-iso-20022-mean-for-corporates/). There is even work being done to pass [tokenized monetary value](https://ripple.com/insights/iso-20022-shaping-the-future-of-cross-border-payments/) itself across across the wire using this standard, causing the money/value to settle at the same moment the message itself settles.

Even if you plan on changing toolsets somewhere down the road, it would be wise to start adapting your domain model to this new standard.

## What this library provides

This library [covers all currently defined messages](https://github.com/Beneficial-Strategies/Iso20022Library/blob/main/doc/Scope-Statement.md) in the ISO specification, plus both XML and JSON serialization and deserialization. Great attention has been paid to:

- **Intellisense-friendly**: packaged so your IDE has access to source and commentary on all types, giving you context on how each class or field should be used.
- **Compiler-enforced**: `required` properties ensure the compiler helps you construct valid ISO 20022 messages rather than discovering missing data at runtime.
- **Immutable records**: full value-equivalence throughout; thread-safe by design.
- **Strongly-typed dates and codes**: no string-typed enums, no ambiguous date formats.
- **Multiplicity-correct**: where a field allows multiple values, it's a collection; where it's optional, it's nullable.
- **Strongly-typed identifiers**: industry-specific identifiers like CUSIP, SEDOL, IBAN, and BIC are strongly typed, not bare strings; because the implementation is strongly-typed all the way down to the primitives, dirty data that doesn't fit the ISO 20022 spec can never be introduced into your system in the first place.

## Install

```
dotnet add package BeneficialStrategies.Iso20022 --version 0.7.0-alpha
```

This brings the primitive types ([BeneficialStrategies.Iso20022.Primitives](https://www.nuget.org/packages/BeneficialStrategies.Iso20022.Primitives)) and the interfaces ([BeneficialStrategies.Iso20022.Messages](https://www.nuget.org/packages/BeneficialStrategies.Iso20022.Messages)). The packages are in alpha, so the commands name the version. It targets net8.0 and net10.0 (the primitives, the interfaces and the validators also target netstandard2.0). It is presumed you already have the [latest .NET SDK](https://dotnet.microsoft.com/en-us/download/visual-studio-sdks) installed, and a text editor, preferably with the [C# Dev Kit](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csdevkit).

Four examples, each a step further. They all use nothing but this package.

## 1. Build a message

```bash
mkdir test
cd test
dotnet new console
dotnet add package BeneficialStrategies.Iso20022 --version 0.7.0-alpha
```

Open your `Program.cs` and paste the following:

```C#
using Beneficial = BeneficialStrategies.Iso20022;
using BeneficialStrategies.Iso20022.Codesets;

var myMessage = new Beneficial.pain.CustomerCreditTransferInitiationV11
{
    GroupHeader = new()
    {
        MessageIdentification = "ABC/120928/CCT001",
        CreationDateTime = new DateTime(2012, 09, 28, 14, 7, 0),
        NumberOfTransactions = "3",
        ControlSum = 11_500_000,
        InitiatingParty = new()
        {
            Name = "ABC Corporation",
            PostalAddress = new()
            {
                StreetName = "Times Square",
                BuildingNumber = "7",
                PostCode = "NY 10036",
                TownName = "New York",
                Country = "US"
            },
        },
    },
    PaymentInformation =
    [
        new()
        {
            PaymentInformationIdentification = "ABC/086",
            PaymentMethod = PaymentMethod3Code.CreditTransfer,
            BatchBooking = "false",
            RequestedExecutionDate = new Beneficial.Choices.DateAndDateTime2Choice.Date { Value = new DateOnly(2012, 09, 29) },
            Debtor = new()
            {
                Name = "ABC Corporation",
                PostalAddress = new()
                {
                    StreetName = "Times Square",
                    BuildingNumber = "7",
                    PostCode = "NY 10036",
                    TownName = "New York",
                    Country = "US"
                },
            },
            DebtorAccount = new()
            {
                Identification = new Beneficial.Choices.AccountIdentification4Choice.Other
                {
                    Identification = "00125574999",
                },
            },
            DebtorAgent = new()
            {
                FinancialInstitutionIdentification = new()
                {
                    BICFI = "BBBBUS33",
                },
            },
            CreditTransferTransactionInformation =
            [
                new()
                {
                    PaymentIdentification = new()
                    {
                        InstructionIdentification = "ABC/120928/CCT001/1",
                        EndToEndIdentification = "ABC/4562/2012-09-08",
                    },
                    Amount = new Beneficial.Choices.AmountType4Choice.InstructedAmount { Currency = "USD", Amount = 10_000_000m },
                    ChargeBearer = ChargeBearerType1Code.Shared,
                    CreditorAgent = new()
                    {
                        FinancialInstitutionIdentification = new()
                        {
                            BICFI = "AAAAGB2L",
                        },
                    },
                    Creditor = new()
                    {
                        Name = "DEF Electronics",
                        PostalAddress = new()
                        {
                            AddressLine = [
                                "Corn Exchange 5th Floor",
                                "Mark Lane 55",
                                "EC3R 7NE London",
                                "GB"
                            ]
                        },
                    },
                    CreditorAccount = new()
                    {
                        Identification = new Beneficial.Choices.AccountIdentification4Choice.Other
                        {
                            Identification = "23683707994215",
                        },
                    },
                    Purpose = new Beneficial.Choices.Purpose2Choice.Code
                    {
                        Value = ExternalPurpose1Code.InstantPaymentsForDonations,
                    },
                    RemittanceInformation = new()
                    {
                        Structured =
                        [
                            new()
                            {
                                ReferredDocumentInformation =
                                [
                                    new()
                                    {
                                        Type = new()
                                        {
                                            CodeOrProprietary = new Beneficial.Choices.ReferredDocumentType3Choice.Code
                                            {
                                                Value = DocumentType6Code.CommercialInvoice,
                                            },
                                        },
                                        Number = "4562",
                                        RelatedDate = new DateOnly(2012, 09, 08),
                                    }
                                ],
                            }
                        ],
                    },
                },
                // Add additional transactions here
            ]
        },
    ],
    // Optionally add Supplementary data at this level
};
```

Things to notice:

- The compiler helps you do the right thing: everything is strongly typed, so you won't accidentally assign the wrong type.
- Intellisense gives you spec-level context on every field as you type.
- Date/time values are strongly typed: no ambiguous string formats.
- `required` members are what the message needs; a field that may repeat is a list (`PaymentInformation = [ ... ]`), and one that is optional is nullable.
- Use Shift-Spacebar to discover optional fields at any level.
- There are 3,339 messages just like this one.

## 2. Write it as XML, or JSON

Add one more using at the top of your file:

```C#
using BeneficialStrategies.Iso20022.Serialization; // for Iso20022XmlSerializer and Iso20022JsonSerializer
```

Then serialize the message to an XML string:

```C#
string xml = Iso20022XmlSerializer.SerializeToString(myMessage);
```

The result is a standards-compliant ISO 20022 XML document:

```xml
<Document xmlns="urn:iso:std:iso:20022:tech:xsd:pain.001.001.11">
  <CstmrCdtTrfInitn>
    <GrpHdr>
      <MsgId>ABC/120928/CCT001</MsgId>
      <CreDtTm>2012-09-28T14:07:00</CreDtTm>
      <NbOfTxs>3</NbOfTxs>
      <CtrlSum>11500000</CtrlSum>
      <InitgPty>
        <Nm>ABC Corporation</Nm>
        <PstlAdr>
          <StrtNm>Times Square</StrtNm>
          <BldgNb>7</BldgNb>
          <PstCd>NY 10036</PstCd>
          <TwnNm>New York</TwnNm>
          <Ctry>US</Ctry>
        </PstlAdr>
      </InitgPty>
    </GrpHdr>
    <PmtInf>
      <PmtInfId>ABC/086</PmtInfId>
      <PmtMtd>TRF</PmtMtd>
      <BtchBookg>false</BtchBookg>
      <ReqdExctnDt>
        <Dt>2012-09-29</Dt>
      </ReqdExctnDt>
      <Dbtr>
        <Nm>ABC Corporation</Nm>
        <PstlAdr>
          <StrtNm>Times Square</StrtNm>
          <BldgNb>7</BldgNb>
          <PstCd>NY 10036</PstCd>
          <TwnNm>New York</TwnNm>
          <Ctry>US</Ctry>
        </PstlAdr>
      </Dbtr>
      <DbtrAcct>
        <Id>
          <Othr>
            <Id>00125574999</Id>
          </Othr>
        </Id>
      </DbtrAcct>
      <DbtrAgt>
        <FinInstnId>
          <BICFI>BBBBUS33</BICFI>
        </FinInstnId>
      </DbtrAgt>
      <CdtTrfTxInf>
        <PmtId>
          <InstrId>ABC/120928/CCT001/1</InstrId>
          <EndToEndId>ABC/4562/2012-09-08</EndToEndId>
        </PmtId>
        <Amt>
          <InstdAmt Ccy="USD">10000000</InstdAmt>
        </Amt>
        <ChrgBr>SHAR</ChrgBr>
        <CdtrAgt>
          <FinInstnId>
            <BICFI>AAAAGB2L</BICFI>
          </FinInstnId>
        </CdtrAgt>
        <Cdtr>
          <Nm>DEF Electronics</Nm>
          <PstlAdr>
            <AdrLine>Corn Exchange 5th Floor</AdrLine>
            <AdrLine>Mark Lane 55</AdrLine>
            <AdrLine>EC3R 7NE London</AdrLine>
            <AdrLine>GB</AdrLine>
          </PstlAdr>
        </Cdtr>
        <CdtrAcct>
          <Id>
            <Othr>
              <Id>23683707994215</Id>
            </Othr>
          </Id>
        </CdtrAcct>
        <Purp>
          <Cd>IPDO</Cd>
        </Purp>
        <RmtInf>
          <Strd>
            <RfrdDocInf>
              <Tp>
                <CdOrPrtry>
                  <Cd>CINV</Cd>
                </CdOrPrtry>
              </Tp>
              <Nb>4562</Nb>
              <RltdDt>2012-09-08</RltdDt>
            </RfrdDocInf>
          </Strd>
        </RmtInf>
      </CdtTrfTxInf>
    </PmtInf>
  </CstmrCdtTrfInitn>
</Document>
```

The same message as JSON, with the ISO naming (`snake_case` property names, the wire codes of the code sets, every amount as a string):

```C#
string json = Iso20022JsonSerializer.SerializeToString(myMessage);
// {"group_header":{"message_identification":"ABC/120928/CCT001","creation_date_time":"2012-09-28T14:07:00", ...
```

## 3. Read it back, and what is wrong with what you were sent

Given that XML string (or one received from a counterparty), read it back to a strongly-typed record:

```C#
var received = Iso20022XmlSerializer.Deserialize<Beneficial.pain.CustomerCreditTransferInitiationV11>(xml);

// All fields are strongly typed and ready to use:
string msgId      = received.GroupHeader.MessageIdentification;                                  // "ABC/120928/CCT001"
string debtorName = received.PaymentInformation[0].Debtor!.Name!;                                // "ABC Corporation"
int    txCount    = received.PaymentInformation[0].CreditTransferTransactionInformation.Count;   // 1
```

`Deserialize` throws an `Iso20022DeserializationException` when the XML cannot be read, and the exception carries **every** problem found (`Issues`; `Path`, `Line`, `Position` and `Value` are those of the first). For XML from a counterparty you would rather ask than catch, so use `TryRead`: it never throws for a problem in the document, and it returns either the complete record or the list of everything that is wrong:

```C#
var result = Iso20022XmlSerializer.TryRead<Beneficial.pain.CustomerCreditTransferInitiationV11>(xml);

if (result.Succeeded)
{
    var received = result.Message!;   // complete: every required member is present and valid
}
else
{
    foreach (DeserializationIssue issue in result.Issues)
        Console.WriteLine(issue);
}
```

With the message identification missing and a charge bearer that is not a code:

```
Document/CstmrCdtTrfInitn/GrpHdr/MsgId: RequiredMissing: Required element <MsgId> is missing. (line 3, position 6)
Document/CstmrCdtTrfInitn/PmtInf[1]/CdtTrfTxInf[1]/ChrgBr: BadValue: 'FREE' is not a value of ChargeBearerType1Code. Expected one of: DEBT, CRED, SHAR, SLEV. (line 56, position 10)
```

Each issue has a `Path` (element names from the document element, with `[2]` on repeated elements and `/@Ccy` for an attribute), a `Code` (`RequiredMissing`, `BadValue`, `FacetViolation`, `UnknownChoice`, `AmbiguousChoice`, `UnexpectedElement`, `MalformedXml`, `WrongRoot`), the offending `Value`, a `Reason`, and the `Line` and `Position` in the text. An enum value is matched against the ISO codes only, and the reason lists the valid ones.

To read one part of a larger document, for example a party you found inside your own envelope, call `Read` on its element. The namespace is taken from the element, and the issue paths can continue from your own path:

```C#
var party = Iso20022XmlSerializer.Read<Beneficial.Components.PartyIdentification135>(
    element, new ReadContext(PathPrefix: "Envelope/Body/"));
```

JSON works the same way: `Iso20022JsonSerializer.Deserialize<T>(json)` throws a `JsonException` for a value that breaks its type, with the JSON path in `Path`, and `Iso20022JsonSerializer.TryDeserialize<T>(json, out var message, out var error)` returns `false` instead of throwing.

## 4. The record is an implementation of an interface

Every record implements the interface of its shape, and the interface is what the rest of the family is written against:

```C#
Beneficial.pain.ICustomerCreditTransferInitiationV11 message = myMessage;
Console.WriteLine(message.GroupHeader.MessageIdentification);   // ABC/120928/CCT001
```

So this one message can be handed to anything that takes the interface (a method of your own, a validator, a consumer of a message bus) without that code knowing, or depending on, the records. See [Where the records fit](#where-the-records-fit).

## Where the records fit

The records are the ready-made implementation. They are the convenient way to get started, and nothing else in the family requires them:

| You want | Package |
|---|---|
| the rules the types cannot express, as FluentValidation validators for these messages | [BeneficialStrategies.Iso20022.FluentValidation](https://www.nuget.org/packages/BeneficialStrategies.Iso20022.FluentValidation) (business-rule validation: constraints the C# type system alone can't express) |
| to validate XML or JSON text, a document or a queue payload, with every problem reported | [BeneficialStrategies.Iso20022.FluentValidation.Xml](https://www.nuget.org/packages/BeneficialStrategies.Iso20022.FluentValidation.Xml) and [.Payloads](https://www.nuget.org/packages/BeneficialStrategies.Iso20022.FluentValidation.Payloads) |
| the same tools **without** the records (your own classes, or classes made for you on the fly) | [BeneficialStrategies.Iso20022.Messages](https://www.nuget.org/packages/BeneficialStrategies.Iso20022.Messages) and [BeneficialStrategies.Iso20022.Factory](https://www.nuget.org/packages/BeneficialStrategies.Iso20022.Factory) |
| only the primitive types, not the message records | [BeneficialStrategies.Iso20022.Primitives](https://www.nuget.org/packages/BeneficialStrategies.Iso20022.Primitives) (this package depends on it; the namespaces are the same in both) |

## What's notably missing

- XML Schema Validation (the XML written by this library is checked against ISO's schemas in this repository's own tests, but there is no runtime schema validation)

**Known limitations:**

- Digital signatures not yet supported
- External content not yet supported
- External schema not yet supported

## Why is this approach better?

The most common quick-and-dirty approach to serializing these messages is to use the only marginally supported [Microsoft XSD tool](https://learn.microsoft.com/en-us/dotnet/standard/serialization/xml-schema-definition-tool-xsd-exe) to generate a data proxy. If you only have a few messages to support, that might be a worthy approach. Here are the reasons you might not want to:

- Most of the classes generated in the proxy are repeats that are also used in other messages.
    - You get zero reuse across messages.
    - If you have a certain type of Name and Address object in one message, you cannot assign it to another object in a different message because they are two different data types.
    - If you end up using many ISO messages, you get code glut over time since there are multiple copies of many objects.
- There is zero documentation burned into the proxy contents.
- If there's something wrong about the way it generates, there's little you can do to fix it.
- It is difficult to create frameworks around these proxy objects because there are no interfaces in common and no shared data objects.

## A word about the future

[Beneficial Strategies](https://www.beneficialstrategies.com/iso20022/) maintains this library as an ongoing output of building and testing the [Beneficial Strategies ISO 20022 MCP Server](https://beneficialstrategies.com/product/mcp-server/) — expect updates as the ISO 20022 organization publishes new snapshots of the standard. Updates and fixes generally fall into these categories:

- ISO20022 standard update — feature branch
- Improvements in metadata
- Correction of cardinality or data relationships — defect branch
- Tweaking of compile directives across versions

For anyone having a dependency on this library, the changes should be easy to maintain. When you update the reference to the new version, the compiler will let you know immediately if it sees any breaking changes.

Questions or feedback? Reach us at [support@beneficialstrategies.com](mailto:support@beneficialstrategies.com).
