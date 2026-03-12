// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the specification of the charge payment method.
    /// </summary>
    [KnownType(typeof(ChargePaymentMethod1Choice.Code))]
    [KnownType(typeof(ChargePaymentMethod1Choice.Proprietary))]
    [JsonDerivedType(typeof(ChargePaymentMethod1Choice.Code),nameof(ChargePaymentMethod1Choice.Code))]
    [JsonDerivedType(typeof(ChargePaymentMethod1Choice.Proprietary),nameof(ChargePaymentMethod1Choice.Proprietary))]
    [IsoId("_ufg1QRXxEeOBE-jZfcm4KQ")]
    [DisplayName("Charge Payment Method 1 Choice")]
    public abstract partial record ChargePaymentMethod1Choice_
    {
    }
}
