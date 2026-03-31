// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of information related to the cancellation request, such as actors involved and identification of the original multiple invoice financing request to which the cancellation request is referring.
/// </summary>
[IsoId("_TiiQo9p-Ed-ak6NoX_4Aeg_1653900933")]
[DisplayName("Cancellation Request Information")]
public record CancellationRequestInformation1
{
    /// <summary>
    /// Unique and unambiguous identifier of the original financing request message as assigned by the original sending party.
    /// </summary>
    [IsoId("_TiiQpNp-Ed-ak6NoX_4Aeg_1653900935")]
    [DisplayName("Original Group Identification")]
    [IsoXmlTag("OrgnlGrpId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OriginalGroupIdentification { get; init; }

    /// <summary>
    /// Date and time at which the original financing request message was created.
    /// </summary>
    [IsoId("_TiiQpdp-Ed-ak6NoX_4Aeg_1653900951")]
    [DisplayName("Original Creation Date Time")]
    [IsoXmlTag("OrgnlCreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime OriginalCreationDateTime { get; init; }

    /// <summary>
    /// Specifies the number of single invoice financing requests included in the original financing request message.
    /// </summary>
    [IsoId("_TiiQptp-Ed-ak6NoX_4Aeg_1653900968")]
    [DisplayName("Number Of Invoice Requests")]
    [IsoXmlTag("NbOfInvcReqs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? NumberOfInvoiceRequests { get; init; }

    /// <summary>
    /// Total amount of the bulk invoice financing request. It is composed by the sum of the total amounts of all invoices included in the original financing request message.
    /// </summary>
    [IsoId("_TiiQp9p-Ed-ak6NoX_4Aeg_1653900986")]
    [DisplayName("Total Bulk Invoice Amount")]
    [IsoXmlTag("TtlBlkInvcAmt")]
    public ActiveCurrencyAndAmount? TotalBulkInvoiceAmount { get; init; }

    /// <summary>
    /// Further details on the cancellation request information, in an uncoded form.
    /// </summary>
    [IsoId("_TiiQqNp-Ed-ak6NoX_4Aeg_-96892245")]
    [DisplayName("Cancellation Reason")]
    [IsoXmlTag("CxlRsn")]
    [IsoSimpleType(IsoSimpleType.Max105Text)]
    [StringLength(maximumLength: 105, MinimumLength = 1)]
    public required IsoMax105Text CancellationReason { get; init; }

    /// <summary>
    /// Party that requests the cancellation of a financing request previously sent.
    /// </summary>
    [IsoId("_TirakNp-Ed-ak6NoX_4Aeg_-606230601")]
    [DisplayName("Financing Requestor")]
    [IsoXmlTag("FincgRqstr")]
    public PartyIdentificationAndAccount6? FinancingRequestor { get; init; }

    /// <summary>
    /// Financial institution that receives the request from the financing requestor and forwards it to the first agent for execution.
    /// </summary>
    [IsoId("_Tirakdp-Ed-ak6NoX_4Aeg_-604384907")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt")]
    public FinancialInstitutionIdentification6? IntermediaryAgent { get; init; }

    /// <summary>
    /// Financial institution of financing requestor to which an invoice financing cancellation request is addressed.
    /// </summary>
    [IsoId("_Tiraktp-Ed-ak6NoX_4Aeg_-603459399")]
    [DisplayName("First Agent")]
    [IsoXmlTag("FrstAgt")]
    public FinancialInstitutionIdentification6? FirstAgent { get; init; }
}
