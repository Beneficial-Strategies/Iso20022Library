# Beneficial Strategies ISO20022 Library

This project contains a .NET implementation of containers for 2,665 different types of financial services messages as defined by the [ISO20022](https://iso20022.org) standard.

It is an ongoing proof-of-concept demonstrating what this library can do, maintained with the assistance of the [Beneficial Strategies ISO20022 AI MCP Server](https://beneficialstrategies.com/product/mcp-server/).

## Let's talk why

[ISO20022](https://iso20022.org) is fast becoming the defacto [inter-partner financial communication language](https://businesspaymentscoalition.org/wp-content/uploads/0217-bpc-intro-iso20022.pdf) for sending financial information. It is being [adopted in the US](https://businesspaymentscoalition.org/wp-content/uploads/0517-us-adoption-iso20022.pdf) and also [being adopted world-wide](https://medium.datadriveninvestor.com/world-digital-currencies-are-already-here-cbdcs-bc756bd899b9).
It's not just for banks any more. Experts are encouraging corporations to hasten with a [migration strategy](https://blogs.opentext.com/what-does-iso-20022-mean-for-corporates/). There is even work being done to pass [tokenized monetary value](https://ripple.com/insights/iso-20022-shaping-the-future-of-cross-border-payments/) itself across across the wire using this standard, causing the money/value to settle at the same moment the message itself settles.

Even if you plan on changing toolsets somewhere down the road, it would be wise to start adapting your domain model to this new standard.

## What this library provides

This library [covers all currently defined messages](doc/Scope-Statement.md) in the ISO specification — over 2,600 message types — plus XML serialization and deserialization. Great attention has been paid to:

- **Intellisense-friendly** — packaged so your IDE has access to source and commentary on all types, giving you context on how each class or field should be used.
- **Compiler-enforced** — `required` properties ensure the compiler helps you construct valid ISO 20022 messages rather than discovering missing data at runtime.
- **Immutable records** — full value-equivalence throughout; thread-safe by design.
- **Strongly-typed dates and codes** — no string-typed enums, no ambiguous date formats.
- **Multiplicity-correct** — where a field allows multiple values, it's a collection; where it's optional, it's nullable.

## What's notably missing

- XML Schema Validation
- Business rules validation (a FluentValidation-based project has been started in this repository but is not yet published to NuGet)

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

The future of this library remains to be seen based on interest. [Beneficial Strategies](https://www.beneficialstrategies.com/iso20022/) continues to maintain and evolve the library as a proof-of-concept for the [ISO20022 AI MCP Server](https://beneficialstrategies.com/product/mcp-server/). Updates and fixes generally fall into these categories:

- ISO20022 standard update — feature branch
- Improvements in metadata
- Correction of cardinality or data relationships — defect branch
- Tweaking of compile directives across versions

For anyone having a dependency on this library, the changes should be easy to maintain. When you update the reference to the new version, the compiler will let you know immediately if it sees any breaking changes.

Questions or feedback? Reach us at [admin@beneficialstrategies.com](mailto:admin@beneficialstrategies.com).

## Trying out the library

It is presumed you already have the [latest .NET SDK](https://dotnet.microsoft.com/en-us/download/visual-studio-sdks) installed. You should also have [Visual Studio Code](https://code.visualstudio.com/download) or some other text editor, preferably with the [C# Dev Kit](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csdevkit).

```bash
mkdir test
cd test
dotnet new console
dotnet add package BeneficialStrategies.Iso20022 --version 0.5.0-alpha
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
    PaymentInformation = new()
    {
        PaymentInformationIdentification = "ABC/086",
        PaymentMethod = PaymentMethod3Code.CreditTransfer,
        BatchBooking = "FALSE",
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
        ]
    },
};
```

Things to notice:

- The compiler helps you do the right thing — everything is strongly typed, so you won't accidentally assign the wrong type.
- Intellisense gives you spec-level context on every field as you type.
- Date/time values are strongly typed — no ambiguous string formats.
- Use Shift-Spacebar to discover optional fields at any level.
- There are over 2,600 messages just like this one.

## Serializing to XML

Add one more using at the top of your file:

```C#
using BeneficialStrategies.Iso20022; // for Iso20022XmlSerializer
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
      <BtchBookg>FALSE</BtchBookg>
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

## Deserializing from XML

Given that XML string (or one received from a counterparty), deserialize it back to a strongly-typed record:

```C#
var received = Iso20022XmlSerializer.Deserialize<Beneficial.pain.CustomerCreditTransferInitiationV11>(xml);

// All fields are strongly typed and ready to use:
string msgId      = received.GroupHeader.MessageIdentification;  // "ABC/120928/CCT001"
string debtorName = received.PaymentInformation.Debtor.Name!;   // "ABC Corporation"
int    txCount    = received.PaymentInformation.CreditTransferTransactionInformation.Count; // 1
```
