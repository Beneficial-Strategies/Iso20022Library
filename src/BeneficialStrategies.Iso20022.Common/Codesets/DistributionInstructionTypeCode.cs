// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of distribution instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_awnn9dp-Ed-ak6NoX_4Aeg_-2013477214")]
[Description(@"Specifies the type of distribution instruction.")]
[Derivations(typeof(DistributionInstructionType1Code))]
public enum DistributionInstructionTypeCode
{
    /// <summary>
    /// Instruction to debit the positions held under all clients accounts in the underlying resouces of the given event and option. This order applies to all clients who are eligible to participate to the CA event.
    /// Encoded/decoded by serializers as &quot;GDEB&quot;.
    /// </summary>
    [EnumMember(Value = "GDEB")]
    [IsoId("_awnn9tp-Ed-ak6NoX_4Aeg_-1931283764")]
    [Description(
        @"Instruction to debit the positions held under all clients accounts in the underlying resouces of the given event and option. This order applies to all clients who are eligible to participate to the CA event."
    )]
    GlobalDebitOrder,

    /// <summary>
    /// An instruction, on a per client basis, to debit the position held in the underlying resources (securities and/or cash) and/or the credit of the proceeds (securities and/or cash).
    /// Encoded/decoded by serializers as &quot;IDEB&quot;.
    /// </summary>
    [EnumMember(Value = "IDEB")]
    [IsoId("_awnn99p-Ed-ak6NoX_4Aeg_-1609897073")]
    [Description(
        @"An instruction, on a per client basis, to debit the position held in the underlying resources (securities and/or cash) and/or the credit of the proceeds (securities and/or cash)."
    )]
    IndividualOrder,

    /// <summary>
    /// Instruction to transfer securities from the clients sequestered balances back to the respective available balances.
    /// Encoded/decoded by serializers as &quot;GRET&quot;.
    /// </summary>
    [EnumMember(Value = "GRET")]
    [IsoId("_awnn-Np-Ed-ak6NoX_4Aeg_-1913734027")]
    [Description(
        @"Instruction to transfer securities from the clients sequestered balances back to the respective available balances."
    )]
    GlobalReturnOrder,

    /// <summary>
    /// Instruction to transfer the position from one sequestered balance (related to a CA option) to another sequestered balalnce (related to another CA option).
    /// Encoded/decoded by serializers as &quot;CHAN&quot;.
    /// </summary>
    [EnumMember(Value = "CHAN")]
    [IsoId("_awwx4Np-Ed-ak6NoX_4Aeg_-1666232744")]
    [Description(
        @"Instruction to transfer the position from one sequestered balance (related to a CA option) to another sequestered balalnce (related to another CA option)."
    )]
    OptionChangeOrder,

    /// <summary>
    /// Instruction to transfer securities from a client sequestered balance back to its available balance.
    /// Encoded/decoded by serializers as &quot;IRET&quot;.
    /// </summary>
    [EnumMember(Value = "IRET")]
    [IsoId("_awwx4dp-Ed-ak6NoX_4Aeg_710372980")]
    [Description(
        @"Instruction to transfer securities from a client sequestered balance back to its available balance."
    )]
    IndividualReturnOrder,
}
