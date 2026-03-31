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
[IsoId("_ti2JYlkyEeGeoaLUQk__nA_922286643")]
[DisplayName("Charges Record")]
public record ChargesRecord1
{
    /// <summary>
    /// Transaction charges to be paid by the charge bearer.
    /// </summary>
    [IsoId("_ti2JY1kyEeGeoaLUQk__nA_1457321897")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveOrHistoricCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Indicates whether the charges amount is a credit or a debit amount. |Usage: A zero amount is considered to be a credit.
    /// </summary>
    [IsoId("_ti_TUFkyEeGeoaLUQk__nA_622556064")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public CreditDebitCode? CreditDebitIndicator { get; init; }

    /// <summary>
    /// Specifies the type of charge.
    /// </summary>
    [IsoId("_ti_TUVkyEeGeoaLUQk__nA_319499549")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public ChargeType3Choice_? Type { get; init; }

    /// <summary>
    /// Rate used to calculate the amount of the charge or fee.
    /// </summary>
    [IsoId("_ti_TUlkyEeGeoaLUQk__nA_1662590359")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? Rate { get; init; }

    /// <summary>
    /// Specifies which party/parties will bear the charges associated with the processing of the payment transaction.
    /// </summary>
    [IsoId("_ti_TU1kyEeGeoaLUQk__nA_590585300")]
    [DisplayName("Bearer")]
    [IsoXmlTag("Br")]
    public ChargeBearerType1Code? Bearer { get; init; }

    /// <summary>
    /// Agent that takes the transaction charges or to which the transaction charges are due.
    /// </summary>
    [IsoId("_ti_TVFkyEeGeoaLUQk__nA_-417585830")]
    [DisplayName("Agent")]
    [IsoXmlTag("Agt")]
    public BranchAndFinancialInstitutionIdentification5? Agent { get; init; }

    /// <summary>
    /// Provides details on the tax applied to charges.
    /// </summary>
    [IsoId("_tjJEUFkyEeGeoaLUQk__nA_-1722428073")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public TaxCharges2? Tax { get; init; }
}
