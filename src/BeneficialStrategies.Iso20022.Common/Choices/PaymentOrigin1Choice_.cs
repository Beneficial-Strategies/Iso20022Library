// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the format under which the payment that generated the entry was transmitted.
    /// </summary>
    [KnownType(typeof(PaymentOrigin1Choice.FINMessageType))]
    [KnownType(typeof(PaymentOrigin1Choice.XMLMessageName))]
    [KnownType(typeof(PaymentOrigin1Choice.Proprietary))]
    [KnownType(typeof(PaymentOrigin1Choice.Instrument))]
    [JsonDerivedType(typeof(PaymentOrigin1Choice.FINMessageType),nameof(PaymentOrigin1Choice.FINMessageType))]
    [JsonDerivedType(typeof(PaymentOrigin1Choice.XMLMessageName),nameof(PaymentOrigin1Choice.XMLMessageName))]
    [JsonDerivedType(typeof(PaymentOrigin1Choice.Proprietary),nameof(PaymentOrigin1Choice.Proprietary))]
    [JsonDerivedType(typeof(PaymentOrigin1Choice.Instrument),nameof(PaymentOrigin1Choice.Instrument))]
    [IsoId("_RIwV1Np-Ed-ak6NoX_4Aeg_1623377139")]
    [DisplayName("Payment Origin 1 Choice")]
    public abstract partial record PaymentOrigin1Choice_
    {
    }
}
