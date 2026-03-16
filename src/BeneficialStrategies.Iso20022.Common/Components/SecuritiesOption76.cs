// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the corporate action security option.
/// </summary>
[IsoId("_Xh1NfdsbEeqmdMJWobugpw")]
[DisplayName("Securities Option")]
public record SecuritiesOption76
{
    /// <summary>
    /// Identification of the financial instrument.
    /// </summary>
    [IsoId("_rTQp9NvXEeqmdMJWobugpw")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Specifies whether the value is a debit or credit.
    /// </summary>
    [IsoId("_Xh1NkNsbEeqmdMJWobugpw")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public required CreditDebitCode CreditDebitIndicator { get; init; }

    /// <summary>
    /// Quantity of securities based on the terms of the corporate action event and balance of underlying securities entitled to the account owner. (This quantity can be positive or negative).
    /// </summary>
    [IsoId("_Xh1NgdsbEeqmdMJWobugpw")]
    [DisplayName("Entitled Quantity")]
    [IsoXmlTag("EntitldQty")]
    public required Quantity6Choice_ EntitledQuantity { get; init; }

    /// <summary>
    /// Date/time at which the movement is due to take place (cash and/or securities).
    /// </summary>
    [IsoId("_2WtPtNsbEeqmdMJWobugpw")]
    [DisplayName("Payment Date")]
    [IsoXmlTag("PmtDt")]
    public required DateFormat58Choice_ PaymentDate { get; init; }
}
