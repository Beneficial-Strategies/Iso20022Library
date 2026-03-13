# Beneficial Strategies ISO20022 Library

This project contains a .NET implementation of containers for 2,665 different types of financial services messages as defined by the [ISO20022](https://iso20022.org) standard.

## Thank you

You are about to download an implementation of the entire domain model for the [ISO20022](https://iso20022.org) standard.
This includes basic serialization to/from XML and JSON according to the ISO20022 specifications.

The purpose of this library, by itself, is to simply present a faithful rendering of the data in memory in a .NET application.
There are follow-on projects that do the serialization, validation, etc.  However, this is the bedrock that must be laid first.

Great attention has been put on certain details:
- It is packaged in a way that your *intellisense* or compatible tech in your build tool should have access to source code.
- You should see commenting on all types giving your analysis information on how each class or setting should be used.
- We go back three versions in .NET core.  
- New features like "required" properties are utilized so the compiler helps you construct valid Iso20022 messages.
- Great effort was made to support records and value-equivilency throughout.
- Where the multiplicity of a property was unapparent, we defaulted to a collection.

Known limitations:
- Digital signatures not yet supported.
- External content not yet supported.
- External schema not yet supported.

For more information about the project, see [the repository](https://github.com/jefforyamos/Iso20022Library).

This is provided free of charge under a very non-restrictive license as a good-faith contribution to the community.  This library is a working proof of concept built using Claude Code and the Beneficial Strategies ISO20022 MCP server soon to be released.

If you have questions or concerns about the implementation, please send developer comments or questions to [admin@beneficialstrategies.com](mailto:admin@beneficialstrategies.com).

## Trying out the library 

To try using the messages, start by putting this using statement in the top of your program.

```C#
using Beneficial = BeneficialStrategies.Iso20022;
using BeneficialStrategies.Iso20022.Codesets;
```

Within your application, you should then be able to instance this message as well as others.  This particular example was taken from [a document](https://www.iso20022.org/business-area-message-set/81/1135/download) on the [Iso20022 web site](https://iso20022.org).

```C#
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
            // Optionally add Contact details, other stuff here
        },
        DebtorAccount = new()
        {
            Identification = new Beneficial.Choices.AccountIdentification4Choice.Other
            {
                Identification = "00125574999",
            },
            // Lots more info you can add here
        },
        DebtorAgent = new()
        {
            FinancialInstitutionIdentification = new ()
            {
                BICFI = "BBBBUS33",
                // Lots more identifying information you can add here
            },
        },
        CreditTransferTransactionInformation =
        [
            new()
            {
                PaymentIdentification = new ()
                {
                    InstructionIdentification = "ABC/120928/CCT001/1",
                    EndToEndIdentification = "ABC/4562/2012-09-08",
                },
                Amount = new Beneficial.Choices.AmountType4Choice.InstructedAmount { Value = 10_000_000m },
                ChargeBearer = ChargeBearerType1Code.Shared,
                CreditorAgent = new()
                {
                    FinancialInstitutionIdentification = new()
                    {
                        BICFI = "AAAAGB2L",
                        // Tons of more identifying information you can optionally add here
                    },
                    // Optionally add branch information here
                },
                Creditor = new()
                {
                    Name = "DEF Electronics",
                    PostalAddress = new()
                    {
                        AddressLine = [
                            "Corn Exchange 5th Floor",
                            "Mark Lane 55",
                            "EC#R7NE London",
                            "GB"
                            ]
                    },
                    // Optionally add ContactDetails, CountryOfResidence, Identification here
                },
                CreditorAccount = new()
                {
                    Identification = new Beneficial.Choices.AccountIdentification4Choice.Other
                    {
                        Identification = "23683707994215",
                        // Optionally add issuer, schema name here 
                    },
                },
                Purpose = new Beneficial.Choices.Purpose2Choice.Code
                {
                    Value = ExternalPurpose1Code.InstantPaymentsForDonations, 
                },
                RemittanceInformation = new()
                {
                    Structured = 
                        new()
                        {
                            ReferredDocumentInformation =
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
                                    RelatedDate = new DateOnly(2012,09,08),
                                    // Optionally add line details here
                                }
                            ,
                            // Add more types of remittances here, use shift-spacebar for pop-up help
                        }
                    ,
                    // Optionally add Unstructured information here
                },
                // LOTS more stuff you can add at this level
            },
            // Add additional transactions here
        ]
    },
    // Optionally add Supplementary data at this level
};

// Now you have data structured in a way you can send to a trading partner or financial institution.

```


