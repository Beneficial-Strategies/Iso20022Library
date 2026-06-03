// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Quantity of assets.
/// </summary>
[IsoId("9f4e9a6d-21be-41d3-a027-b36c24f6f4b4")]
[DisplayName("Quantity54")]
public record Quantity54
{
    /// <summary>
    /// Quantity of security transferred.
    /// </summary>
    [IsoId("0adb884d-1b70-4a08-b774-8d8563810ba8")]
    [DisplayName("Unit")]
    [IsoXmlTag("Unit")]
    public Unit1Choice_? Unit { get; init; }

    /// <summary>
    /// Percentage rate of assets transferred.
    /// </summary>
    [IsoId("8f232dcc-bf0b-486e-856f-2f7162b0f450")]
    [DisplayName("Percentage Rate")]
    [IsoXmlTag("PctgRate")]
    public IsoPercentageRate? PercentageRate { get; init; }

    /// <summary>
    /// Quantity expressed as an amount representing the face amount of a debt instrument.
    /// </summary>
    [IsoId("3fdecf75-9895-4268-8bdb-7159de27abf9")]
    [DisplayName("Face Amount")]
    [IsoXmlTag("FaceAmt")]
    public ImpliedCurrencyAndAmount? FaceAmount { get; init; }

    /// <summary>
    /// Quantity expressed as an amount representing the current amortised face amount of a bond.
    /// </summary>
    [IsoId("7173e376-c46d-4856-809a-c2fb7606a3d9")]
    [DisplayName("Amortised Value")]
    [IsoXmlTag("AmtsdVal")]
    public ImpliedCurrencyAndAmount? AmortisedValue { get; init; }

    /// <summary>
    /// Cash amount transferred.
    /// </summary>
    [IsoId("7d17e5a9-ad43-4b0f-ae8c-5f23a41bc310")]
    [DisplayName("Cash Amount")]
    [IsoXmlTag("CshAmt")]
    public ActiveCurrencyAnd13DecimalAmount? CashAmount { get; init; }

    /// <summary>
    /// Quantity of asset transferred.
    /// </summary>
    [IsoId("0361cf89-71c7-4aff-83a5-1b42ba74a845")]
    [DisplayName("Other Asset")]
    [IsoXmlTag("OthrAsst")]
    public IsoMax35Text? OtherAsset { get; init; }
}
