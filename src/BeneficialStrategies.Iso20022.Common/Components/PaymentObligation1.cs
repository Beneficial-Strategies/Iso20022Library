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
[IsoId("_TmaED9p-Ed-ak6NoX_4Aeg_596881925")]
[DisplayName("Payment Obligation")]
public record PaymentObligation1
{
    /// <summary>
    /// Bank that has to pay under the obligation.
    /// </summary>
    [IsoId("_Tmj1ANp-Ed-ak6NoX_4Aeg_1171310523")]
    [DisplayName("Obligor Bank")]
    [IsoXmlTag("OblgrBk")]
    public required BICIdentification1 ObligorBank { get; init; }

    /// <summary>
    /// Bank that will be paid under the obligation.
    /// </summary>
    [IsoId("_Tmj1Adp-Ed-ak6NoX_4Aeg_1183317260")]
    [DisplayName("Recipient Bank")]
    [IsoXmlTag("RcptBk")]
    public required BICIdentification1 RecipientBank { get; init; }

    /// <summary>
    /// Maximum amount that will be paid under the obligation.
    /// </summary>
    [IsoId("_Tmj1Atp-Ed-ak6NoX_4Aeg_1036477395")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required CurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Maximum amount that will be paid under the obligation, expressed as a percentage of the purchase order net amount.
    /// </summary>
    [IsoId("_Tmj1A9p-Ed-ak6NoX_4Aeg_68097507")]
    [DisplayName("Percentage")]
    [IsoXmlTag("Pctg")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public required IsoPercentageRate Percentage { get; init; }

    /// <summary>
    /// Amount of the charges taken by the obligor bank.
    /// </summary>
    [IsoId("_Tmj1BNp-Ed-ak6NoX_4Aeg_-899180987")]
    [DisplayName("Charges Amount")]
    [IsoXmlTag("ChrgsAmt")]
    public CurrencyAndAmount? ChargesAmount { get; init; }

    /// <summary>
    /// Amount of the charges expressed as a percentage of the amount paid by the obligor bank.
    /// </summary>
    [IsoId("_Tmj1Bdp-Ed-ak6NoX_4Aeg_-870552237")]
    [DisplayName("Charges Percentage")]
    [IsoXmlTag("ChrgsPctg")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? ChargesPercentage { get; init; }

    /// <summary>
    /// Date at which the obligation will expire.
    /// </summary>
    [IsoId("_Tmj1Btp-Ed-ak6NoX_4Aeg_1478843016")]
    [DisplayName("Expiry Date")]
    [IsoXmlTag("XpryDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate ExpiryDate { get; init; }

    /// <summary>
    /// Country of which the law governs the bank payment obligation.
    /// </summary>
    [IsoId("_Tmj1B9p-Ed-ak6NoX_4Aeg_-154804792")]
    [DisplayName("Applicable Law")]
    [IsoXmlTag("AplblLaw")]
    public CountryCode? ApplicableLaw { get; init; }

    /// <summary>
    /// Payment processes required to transfer cash from the debtor to the creditor.
    /// </summary>
    [IsoId("_Tms-8Np-Ed-ak6NoX_4Aeg_1971081576")]
    [DisplayName("Payment Terms")]
    [IsoXmlTag("PmtTerms")]
    public PaymentTerms2? PaymentTerms { get; init; }

    /// <summary>
    /// Instruction between two clearing agents stipulating the cash transfer characteristics between the two parties.
    /// </summary>
    [IsoId("_Tms-8dp-Ed-ak6NoX_4Aeg_-935706746")]
    [DisplayName("Settlement Terms")]
    [IsoXmlTag("SttlmTerms")]
    public SettlementTerms2? SettlementTerms { get; init; }
}
