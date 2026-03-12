// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a code and a data source scheme to determine the customer handling instruction.
    /// </summary>
    [KnownType(typeof(CustomerHandlingInstructionChoice.Code))]
    [KnownType(typeof(CustomerHandlingInstructionChoice.Proprietary))]
    [JsonDerivedType(typeof(CustomerHandlingInstructionChoice.Code),nameof(CustomerHandlingInstructionChoice.Code))]
    [JsonDerivedType(typeof(CustomerHandlingInstructionChoice.Proprietary),nameof(CustomerHandlingInstructionChoice.Proprietary))]
    [IsoId("_Q-K2c9p-Ed-ak6NoX_4Aeg_-1612999730")]
    [DisplayName("Customer Handling Instruction Choice")]
    public abstract partial record CustomerHandlingInstructionChoice_
    {
    }
}
