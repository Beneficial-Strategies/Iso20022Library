// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contain additional amount information of the vehicle rental service.
/// </summary>
[IsoId("_SELowVN8EfC0lMwgjvMClw")]
[DisplayName("Vehicle Rental Additional Amount1")]
public record VehicleRentalAdditionalAmount1
{
    [IsoId("_SGrjIVN8EfC0lMwgjvMClw")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public CarRentalServiceType3Code? Type { get; init; }

    [IsoId("_SGrjJVN8EfC0lMwgjvMClw")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public ImpliedCurrencyAndAmount? Amount { get; init; }

    [IsoId("_SGrjJ1N8EfC0lMwgjvMClw")]
    [DisplayName("Credit Debit")]
    [IsoXmlTag("CdtDbt")]
    public CreditDebit3Code? CreditDebit { get; init; }

    [IsoId("_SGrjKVN8EfC0lMwgjvMClw")]
    [DisplayName("Customer Notified")]
    [IsoXmlTag("CstmrNtfd")]
    public IsoTrueFalseIndicator? CustomerNotified { get; init; }
}
