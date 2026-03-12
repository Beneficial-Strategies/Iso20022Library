// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a status quantity or a quantity to receive for the quantity of financial instrument.
    /// </summary>
    [KnownType(typeof(StatusOrQuantityToReceive1Choice.StatusQuantity))]
    [KnownType(typeof(StatusOrQuantityToReceive1Choice.QuantityToReceive))]
    [JsonDerivedType(typeof(StatusOrQuantityToReceive1Choice.StatusQuantity),nameof(StatusOrQuantityToReceive1Choice.StatusQuantity))]
    [JsonDerivedType(typeof(StatusOrQuantityToReceive1Choice.QuantityToReceive),nameof(StatusOrQuantityToReceive1Choice.QuantityToReceive))]
    [IsoId("_UGl_-tp-Ed-ak6NoX_4Aeg_1067930232")]
    [DisplayName("Status Or Quantity To Receive 1 Choice")]
    public abstract partial record StatusOrQuantityToReceive1Choice_
    {
    }
}
