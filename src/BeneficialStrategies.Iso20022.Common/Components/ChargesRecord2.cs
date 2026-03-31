// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further individual record details on the charges related to the payment transaction.
/// </summary>
[IsoId("_c1FRUSHBEeK_0OuuIoS2mw")]
[DisplayName("Charges Record")]
public record ChargesRecord2
{
    /// <summary>
    /// Transaction charges to be paid by the charge bearer.
    /// </summary>
    [IsoId("_dK_P4SHBEeK_0OuuIoS2mw")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveOrHistoricCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Indicates whether the charges amount is a credit or a debit amount. |Usage: A zero amount is considered to be a credit.
    /// </summary>
    [IsoId("_dK_P5SHBEeK_0OuuIoS2mw")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public CreditDebitCode? CreditDebitIndicator { get; init; }

    /// <summary>
    /// Indicates whether the charge should be included in the amount or is added as pre-advice.
    /// </summary>
    [IsoId("_gXIbwyHBEeK_0OuuIoS2mw")]
    [DisplayName("Charge Included Indicator")]
    [IsoXmlTag("ChrgInclInd")]
    [IsoSimpleType(IsoSimpleType.ChargeIncludedIndicator)]
    public IsoChargeIncludedIndicator? ChargeIncludedIndicator { get; init; }

    /// <summary>
    /// Specifies the type of charge.
    /// </summary>
    [IsoId("_dK_P6SHBEeK_0OuuIoS2mw")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public ChargeType3Choice_? Type { get; init; }

    /// <summary>
    /// Rate used to calculate the amount of the charge or fee.
    /// </summary>
    [IsoId("_dK_P7SHBEeK_0OuuIoS2mw")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? Rate { get; init; }

    /// <summary>
    /// Specifies which party/parties will bear the charges associated with the processing of the payment transaction.
    /// </summary>
    [IsoId("_dK_P8SHBEeK_0OuuIoS2mw")]
    [DisplayName("Bearer")]
    [IsoXmlTag("Br")]
    public ChargeBearerType1Code? Bearer { get; init; }

    /// <summary>
    /// Agent that takes the transaction charges or to which the transaction charges are due.
    /// </summary>
    [IsoId("_dK_P9SHBEeK_0OuuIoS2mw")]
    [DisplayName("Agent")]
    [IsoXmlTag("Agt")]
    public BranchAndFinancialInstitutionIdentification5? Agent { get; init; }

    /// <summary>
    /// Provides details on the tax applied to charges.
    /// </summary>
    [IsoId("_dK_P-SHBEeK_0OuuIoS2mw")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public TaxCharges2? Tax { get; init; }
}
