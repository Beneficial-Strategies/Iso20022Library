// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Reference details of the contract registration.
    /// </summary>
    [KnownType(typeof(ContractRegistrationReference1Choice.RegisteredContractIdentification))]
    [KnownType(typeof(ContractRegistrationReference1Choice.Contract))]
    [JsonDerivedType(typeof(ContractRegistrationReference1Choice.RegisteredContractIdentification),nameof(ContractRegistrationReference1Choice.RegisteredContractIdentification))]
    [JsonDerivedType(typeof(ContractRegistrationReference1Choice.Contract),nameof(ContractRegistrationReference1Choice.Contract))]
    [IsoId("_tyufgdM-EeSDLevdaFPXHw")]
    [DisplayName("Contract Registration Reference 1 Choice")]
    public abstract partial record ContractRegistrationReference1Choice_
    {
    }
}
