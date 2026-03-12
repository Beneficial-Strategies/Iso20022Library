// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Reference details of the contract registration.
    /// </summary>
    [KnownType(typeof(ContractRegistrationReference2Choice.RegisteredContractIdentification))]
    [KnownType(typeof(ContractRegistrationReference2Choice.Contract))]
    [JsonDerivedType(typeof(ContractRegistrationReference2Choice.RegisteredContractIdentification),nameof(ContractRegistrationReference2Choice.RegisteredContractIdentification))]
    [JsonDerivedType(typeof(ContractRegistrationReference2Choice.Contract),nameof(ContractRegistrationReference2Choice.Contract))]
    [IsoId("_KUfpwbMmEeueudaIbClZbQ")]
    [DisplayName("Contract Registration Reference 2 Choice")]
    public abstract partial record ContractRegistrationReference2Choice_
    {
    }
}
