// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of settlement of a transaction.
/// </summary>
[IsoId("_muweMfHcEfChCaiL9q1LKg")]
[DisplayName("Settlement Details236")]
public record SettlementDetails236
{
    [IsoId("_mzFkl_HcEfChCaiL9q1LKg")]
    [DisplayName("Settlement Transaction Condition")]
    [IsoXmlTag("SttlmTxCond")]
    public ValueList<SettlementTransactionCondition47Choice> SettlementTransactionCondition { get; init; } = [];

    [IsoId("_mzFko_HcEfChCaiL9q1LKg")]
    [DisplayName("Registration")]
    [IsoXmlTag("Regn")]
    public Registration9Choice? Registration { get; init; }

    [IsoId("_mzFkr_HcEfChCaiL9q1LKg")]
    [DisplayName("Legal Restrictions")]
    [IsoXmlTag("LglRstrctns")]
    public Restriction5Choice? LegalRestrictions { get; init; }

    [IsoId("_mzFku_HcEfChCaiL9q1LKg")]
    [DisplayName("Securities RTGS")]
    [IsoXmlTag("SctiesRTGS")]
    public SecuritiesRTGS4Choice? SecuritiesRTGS { get; init; }

    [IsoId("_mzFkx_HcEfChCaiL9q1LKg")]
    [DisplayName("Settlement System Method")]
    [IsoXmlTag("SttlmSysMtd")]
    public SettlementSystemMethod4Choice? SettlementSystemMethod { get; init; }

    [IsoId("_mzFk0_HcEfChCaiL9q1LKg")]
    [DisplayName("Tax Capacity")]
    [IsoXmlTag("TaxCpcty")]
    public TaxCapacityParty4Choice? TaxCapacity { get; init; }

    [IsoId("_mzFk3_HcEfChCaiL9q1LKg")]
    [DisplayName("Stamp Duty Tax Basis")]
    [IsoXmlTag("StmpDtyTaxBsis")]
    public GenericIdentification30? StampDutyTaxBasis { get; init; }
}
