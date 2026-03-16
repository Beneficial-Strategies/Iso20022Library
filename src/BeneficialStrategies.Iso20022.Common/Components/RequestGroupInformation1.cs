// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of characteristics that unambiguously identify the global invoice financing request.
/// </summary>
[IsoId("_TiYfoNp-Ed-ak6NoX_4Aeg_1465496511")]
[DisplayName("Request Group Information")]
public record RequestGroupInformation1
{
    /// <summary>
    /// Point to point reference assigned by the financing requestor to unambiguously identify the invoice financing request message.||Usage: The financing requestor has to make sure that &apos;GroupIdentification&apos; is unique for a pre-agreed period.
    /// </summary>
    [IsoId("_TiYfodp-Ed-ak6NoX_4Aeg_1465496537")]
    [DisplayName("Group Identification")]
    [IsoXmlTag("GrpId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text GroupIdentification { get; init; }

    /// <summary>
    /// Date and time on which the invoice financing request was created.
    /// </summary>
    [IsoId("_TiYfotp-Ed-ak6NoX_4Aeg_1465496553")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <summary>
    /// User identification or any user key that allows to check if the financing requestor is allowed to ask for invoice financing.||Usage: the content is not of a technical nature, but reflects the organisational structure at the requesting side.|The authorisation element can typically be used in case the financing requestor acts on behalf of one or more suppliers.
    /// </summary>
    [IsoId("_TiYfo9p-Ed-ak6NoX_4Aeg_515663679")]
    [DisplayName("Authorisation")]
    [IsoXmlTag("Authstn")]
    [IsoSimpleType(IsoSimpleType.Max128Text)]
    [MinLength(0)]
    [MaxLength(2)]
    public SimpleValueList<System.String> Authorisation { get; init; } = [];

    /// <summary>
    /// Specifies the number of single invoice financing requests included in the bulk request message.
    /// </summary>
    [IsoId("_TiYfpNp-Ed-ak6NoX_4Aeg_1465496571")]
    [DisplayName("Number Of Invoice Requests")]
    [IsoXmlTag("NbOfInvcReqs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? NumberOfInvoiceRequests { get; init; }

    /// <summary>
    /// Total amount of the bulk invoice financing request. It is composed by the sum of the total amounts of all invoices included in the financing request.
    /// </summary>
    [IsoId("_TiYfpdp-Ed-ak6NoX_4Aeg_1465496613")]
    [DisplayName("Total Bulk Invoice Amount")]
    [IsoXmlTag("TtlBlkInvcAmt")]
    public ActiveCurrencyAndAmount? TotalBulkInvoiceAmount { get; init; }

    /// <summary>
    /// Reference currency of the invoice financing request.
    /// </summary>
    [IsoId("_TiYfptp-Ed-ak6NoX_4Aeg_1465496631")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public required CurrencyCode Currency { get; init; }

    /// <summary>
    /// Specifies the financing method related to invoice financing (eg collection mandate).
    /// </summary>
    [IsoId("_TiYfp9p-Ed-ak6NoX_4Aeg_1465496648")]
    [DisplayName("Financing Agreement")]
    [IsoXmlTag("FincgAgrmt")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? FinancingAgreement { get; init; }

    /// <summary>
    /// Party that requests the invoice financing, on behalf of a creditor.
    /// </summary>
    [IsoId("_TiYfqNp-Ed-ak6NoX_4Aeg_1465497021")]
    [DisplayName("Financing Requestor")]
    [IsoXmlTag("FincgRqstr")]
    public required PartyIdentificationAndAccount6 FinancingRequestor { get; init; }

    /// <summary>
    /// Financial institution that receives the request from the financing requestor and forwards it to the first agent for execution.
    /// </summary>
    [IsoId("_TiYfqdp-Ed-ak6NoX_4Aeg_1465497004")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt")]
    public FinancialInstitutionIdentification6? IntermediaryAgent { get; init; }

    /// <summary>
    /// Financial institution of financing requestor to which an invoice financing request is addressed.
    /// </summary>
    [IsoId("_TiiQoNp-Ed-ak6NoX_4Aeg_1465496752")]
    [DisplayName("First Agent")]
    [IsoXmlTag("FrstAgt")]
    public required FinancialInstitutionIdentification6 FirstAgent { get; init; }

    /// <summary>
    /// Agreements between financing requestor and his bank concerning conditions about the service of invoice financing, based on specific contractual schemes.
    /// </summary>
    [IsoId("_TiiQodp-Ed-ak6NoX_4Aeg_1465496695")]
    [DisplayName("Agreement Clauses")]
    [IsoXmlTag("AgrmtClauses")]
    public AgreementClauses1? AgreementClauses { get; init; }

    /// <summary>
    /// Additional information about the financing request.
    /// </summary>
    [IsoId("_TiiQotp-Ed-ak6NoX_4Aeg_-1564243574")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public AdditionalInformation1? AdditionalInformation { get; init; }
}
