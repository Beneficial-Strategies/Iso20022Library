// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ICharges16"/>
[IsoId("_x7KXQTEyEe6g-ffJsqGiSA")]
[Description(@"Provides information on the charges related to the payment transaction.")]
[DisplayName("Charges16")]
public partial record Charges16
{
    /// <inheritdoc cref="ICharges16.Agent"/>
    [DisplayName("Agent")]
    [IsoXmlTag("Agt")]
    public required BranchAndFinancialInstitutionIdentification8 Agent { get; init; }

    /// <inheritdoc cref="ICharges16.Amount"/>
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveOrHistoricCurrencyAndAmount Amount { get; init; }

    /// <inheritdoc cref="ICharges16.Type"/>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public ChargeType3Choice_? Type { get; init; }
}
