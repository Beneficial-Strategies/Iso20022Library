// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the message reference of the message for which the status is requested and the business reference of the transfer instruction.
/// </summary>
[IsoId("219fa134-6a0f-4688-927f-51f44b29a8e7")]
[DisplayName("Message And Business Reference14")]
public record MessageAndBusinessReference14
{
    /// <summary>
    /// Reference to the message or communication that was previously sent.
    /// </summary>
    [IsoId("873b73b2-6c13-4d30-b9e2-b460b24bf434")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    public References68Choice_? Reference { get; init; }

    /// <summary>
    /// Type of request required.
    /// </summary>
    [IsoId("27f56b38-468a-4053-a5e5-5ff21f292ccf")]
    [DisplayName("Type Of Request")]
    [IsoXmlTag("TpOfReq")]
    public TypeOfRequest1Choice_? TypeOfRequest { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party.
    /// </summary>
    [IsoId("2b1a7c12-4dea-4e5b-ad02-656504979aa6")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    public IsoMax35Text? MasterReference { get; init; }

    /// <summary>
    /// Unique and unambiguous identification of the transfer, as assigned by the instructing party.
    /// </summary>
    [IsoId("347823a5-021a-4bd3-a013-143062da630b")]
    [DisplayName("Transfer Reference")]
    [IsoXmlTag("TrfRef")]
    public required AdditionalReference10 TransferReference { get; init; }

    /// <summary>
    /// Unique and unambiguous investor's identification of the transfer.
    /// </summary>
    [IsoId("f449b808-91e7-49ec-9795-206adeffac65")]
    [DisplayName("Client Reference")]
    [IsoXmlTag("ClntRef")]
    public AdditionalReference10? ClientReference { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for a transfer cancellation, as assigned by the instructing party.
    /// </summary>
    [IsoId("d78ce04d-4b7d-450a-b5ae-653aaaf63855")]
    [DisplayName("Cancellation Reference")]
    [IsoXmlTag("CxlRef")]
    public IsoMax35Text? CancellationReference { get; init; }

    /// <summary>
    /// Identification of the asset.
    /// </summary>
    [IsoId("cdc47833-320e-458f-9a9a-d584e46dffa7")]
    [DisplayName("Instrument")]
    [IsoXmlTag("Instrm")]
    public FinancialInstrument101Choice_? Instrument { get; init; }

    /// <summary>
    /// Investment account information of the transfer for which the status or information is requested.
    /// </summary>
    [IsoId("f83c5a20-6a39-4dd8-8c78-c8416dfa1a0a")]
    [DisplayName("Investment Account Details")]
    [IsoXmlTag("InvstmtAcctDtls")]
    public Account36? InvestmentAccountDetails { get; init; }

    /// <summary>
    /// Identification of a related party or intermediary.
    /// </summary>
    [IsoId("79950a17-132b-4fa2-98ea-126e3eaf35be")]
    [DisplayName("Intermediary Information")]
    [IsoXmlTag("IntrmyInf")]
    public ValueList<Intermediary48> IntermediaryInformation { get; init; } = [];

    /// <summary>
    /// Information about the query.
    /// </summary>
    [IsoId("72f7d04a-a0f0-4029-9a01-1f2e955847c6")]
    [DisplayName("Query Information")]
    [IsoXmlTag("QryInf")]
    public ValueList<AdditionalInformation25> QueryInformation { get; init; } = [];

    /// <summary>
    /// Party that issues the request message.
    /// </summary>
    [IsoId("bc19ef06-4911-442c-aa69-a7c381c9c37e")]
    [DisplayName("Request Issuer")]
    [IsoXmlTag("ReqIssr")]
    public PartyIdentification139? RequestIssuer { get; init; }

    /// <summary>
    /// Party that receives the request message.
    /// </summary>
    [IsoId("84f8ec07-802d-4d86-a2c6-a98237bbf85c")]
    [DisplayName("Request Recipient")]
    [IsoXmlTag("ReqRcpt")]
    public PartyIdentification139? RequestRecipient { get; init; }
}
