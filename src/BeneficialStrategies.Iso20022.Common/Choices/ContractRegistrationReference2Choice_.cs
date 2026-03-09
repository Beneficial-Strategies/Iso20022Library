// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Reference details of the contract registration.
    /// </summary>
    [KnownType(typeof(ContractRegistrationReference2Choice.RegisteredContractIdentification))]
    [KnownType(typeof(ContractRegistrationReference2Choice.Contract))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ContractRegistrationReference2Choice.RegisteredContractIdentification),nameof(ContractRegistrationReference2Choice.RegisteredContractIdentification))]
    [JsonDerivedType(typeof(ContractRegistrationReference2Choice.Contract),nameof(ContractRegistrationReference2Choice.Contract))]
    #endif
    [IsoId("_KUfpwbMmEeueudaIbClZbQ")]
    [DisplayName("Contract Registration Reference 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ContractRegistrationReference2Choice_
    #else
    public abstract partial class ContractRegistrationReference2Choice_
    #endif
    {
    }
}
