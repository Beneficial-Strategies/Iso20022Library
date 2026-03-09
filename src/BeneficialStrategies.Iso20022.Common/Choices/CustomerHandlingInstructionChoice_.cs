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
    /// Choice between a code and a data source scheme to determine the customer handling instruction.
    /// </summary>
    [KnownType(typeof(CustomerHandlingInstructionChoice.Code))]
    [KnownType(typeof(CustomerHandlingInstructionChoice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CustomerHandlingInstructionChoice.Code),nameof(CustomerHandlingInstructionChoice.Code))]
    [JsonDerivedType(typeof(CustomerHandlingInstructionChoice.Proprietary),nameof(CustomerHandlingInstructionChoice.Proprietary))]
    #endif
    [IsoId("_Q-K2c9p-Ed-ak6NoX_4Aeg_-1612999730")]
    [DisplayName("Customer Handling Instruction Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CustomerHandlingInstructionChoice_
    #else
    public abstract partial class CustomerHandlingInstructionChoice_
    #endif
    {
    }
}
