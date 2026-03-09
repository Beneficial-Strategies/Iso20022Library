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
    /// Choice of format for the instruction processing status.
    /// </summary>
    [KnownType(typeof(InstructionProcessingStatus2Choice.Code))]
    [KnownType(typeof(InstructionProcessingStatus2Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(InstructionProcessingStatus2Choice.Code),nameof(InstructionProcessingStatus2Choice.Code))]
    [JsonDerivedType(typeof(InstructionProcessingStatus2Choice.Proprietary),nameof(InstructionProcessingStatus2Choice.Proprietary))]
    #endif
    [IsoId("_UYBuMNp-Ed-ak6NoX_4Aeg_-1515031070")]
    [DisplayName("Instruction Processing Status 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InstructionProcessingStatus2Choice_
    #else
    public abstract partial class InstructionProcessingStatus2Choice_
    #endif
    {
    }
}
