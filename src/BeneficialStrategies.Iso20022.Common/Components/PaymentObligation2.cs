// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment obligation contracted between two financial institutions related to the financing of a commercial transaction.
/// </summary>
[IsoId("_H7FLkdNVEeKdOs2hjJ_3WQ")]
[DisplayName("Payment Obligation")]
public record PaymentObligation2
{
    /// <summary>
    /// Bank that has to pay under the obligation.
    /// </summary>
    [IsoId("_IbM2E9NVEeKdOs2hjJ_3WQ")]
    [DisplayName("Obligor Bank")]
    [IsoXmlTag("OblgrBk")]
    public required BICIdentification1 ObligorBank { get; init; }

    /// <summary>
    /// Bank that will be paid under the obligation.
    /// </summary>
    [IsoId("_IbM2FdNVEeKdOs2hjJ_3WQ")]
    [DisplayName("Recipient Bank")]
    [IsoXmlTag("RcptBk")]
    public required BICIdentification1 RecipientBank { get; init; }

    /// <summary>
    /// Payment obligation amount specified as an amount or percentage.
    /// </summary>
    [IsoId("_qRrnENP_EeK0PPbKncCqzA")]
    [DisplayName("Payment Obligation Amount")]
    [IsoXmlTag("PmtOblgtnAmt")]
    public required AmountOrPercentage2Choice_ PaymentObligationAmount { get; init; }

    /// <summary>
    /// Charges related to the payment obligation.
    /// </summary>
    [IsoId("_bUWsINP_EeK0PPbKncCqzA")]
    [DisplayName("Charges")]
    [IsoXmlTag("Chrgs")]
    public Charges5? Charges { get; init; }

    /// <summary>
    /// Date at which the obligation will expire.
    /// </summary>
    [IsoId("_IbM2H9NVEeKdOs2hjJ_3WQ")]
    [DisplayName("Expiry Date")]
    [IsoXmlTag("XpryDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate ExpiryDate { get; init; }

    /// <summary>
    /// Rules which apply to the BPO (Bank Payment Obligation).
    /// </summary>
    [IsoId("_VaMaENNrEeKdOs2hjJ_3WQ")]
    [DisplayName("Applicable Rules")]
    [IsoXmlTag("AplblRules")]
    public BPOApplicableRules1Choice_? ApplicableRules { get; init; }

    /// <summary>
    /// Country of which the law governs the bank payment obligation.
    /// </summary>
    [IsoId("_IbM2IdNVEeKdOs2hjJ_3WQ")]
    [DisplayName("Applicable Law")]
    [IsoXmlTag("AplblLaw")]
    public CountryCode? ApplicableLaw { get; init; }

    /// <summary>
    /// Location and forum for dispute resolution.
    /// </summary>
    [IsoId("_aiswQNQAEeK0PPbKncCqzA")]
    [DisplayName("Place Of Jurisdiction")]
    [IsoXmlTag("PlcOfJursdctn")]
    public Location2? PlaceOfJurisdiction { get; init; }

    /// <summary>
    /// Payment processes required to transfer cash from the debtor to the creditor.
    /// </summary>
    [IsoId("_IbM2I9NVEeKdOs2hjJ_3WQ")]
    [DisplayName("Payment Terms")]
    [IsoXmlTag("PmtTerms")]
    public PaymentTerms4? PaymentTerms { get; init; }

    /// <summary>
    /// Instruction between two clearing agents stipulating the cash transfer characteristics between the two parties.
    /// </summary>
    [IsoId("_IbM2JdNVEeKdOs2hjJ_3WQ")]
    [DisplayName("Settlement Terms")]
    [IsoXmlTag("SttlmTerms")]
    public SettlementTerms3? SettlementTerms { get; init; }
}
