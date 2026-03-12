// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the choice of identification of the e-banking application as a contract or a user identification.
    /// </summary>
    [KnownType(typeof(IsabelEbanking1Choice.UserIdentification))]
    [KnownType(typeof(IsabelEbanking1Choice.ContractIdentification))]
    [JsonDerivedType(typeof(IsabelEbanking1Choice.UserIdentification),nameof(IsabelEbanking1Choice.UserIdentification))]
    [JsonDerivedType(typeof(IsabelEbanking1Choice.ContractIdentification),nameof(IsabelEbanking1Choice.ContractIdentification))]
    [IsoId("_F5NoEKA3EeWiJt5KdX5iuQ")]
    [DisplayName("Isabel Ebanking 1 Choice")]
    public abstract partial record IsabelEbanking1Choice_
    {
    }
}
