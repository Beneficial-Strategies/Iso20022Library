// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of distribution instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_awd2-dp-Ed-ak6NoX_4Aeg_-1269116309")]
[Description(@"Specifies the type of distribution instruction.")]
[DerivedFrom(typeof(DistributionInstructionTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<DistributionInstructionType1Code>))]
#endif
public enum DistributionInstructionType1Code
{
    /// <summary>
    /// Instruction to debit the positions held under all clients accounts in the underlying resouces of the given event and option. This order applies to all clients who are eligible to participate to the CA event.
    /// Encoded/decoded by serializers as &quot;GDEB&quot;.
    /// </summary>
    [EnumMember(Value = "GDEB")]
    [IsoId("_awnn8Np-Ed-ak6NoX_4Aeg_-1264498767")]
    [Description(
        @"Instruction to debit the positions held under all clients accounts in the underlying resouces of the given event and option. This order applies to all clients who are eligible to participate to the CA event."
    )]
    GlobalDebitOrder = DistributionInstructionTypeCode.GlobalDebitOrder, // same ordinal as derivation source for type conversions

    /// <summary>
    /// An instruction, on a per client basis, to debit the position held in the underlying resources (securities and/or cash) and/or the credit of the proceeds (securities and/or cash).
    /// Encoded/decoded by serializers as &quot;IDEB&quot;.
    /// </summary>
    [EnumMember(Value = "IDEB")]
    [IsoId("_awnn8dp-Ed-ak6NoX_4Aeg_-1264498766")]
    [Description(
        @"An instruction, on a per client basis, to debit the position held in the underlying resources (securities and/or cash) and/or the credit of the proceeds (securities and/or cash)."
    )]
    IndividualOrder = DistributionInstructionTypeCode.IndividualOrder, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction to transfer securities from the clients sequestered balances back to the respective available balances.
    /// Encoded/decoded by serializers as &quot;GRET&quot;.
    /// </summary>
    [EnumMember(Value = "GRET")]
    [IsoId("_awnn8tp-Ed-ak6NoX_4Aeg_-1264498737")]
    [Description(
        @"Instruction to transfer securities from the clients sequestered balances back to the respective available balances."
    )]
    GlobalReturnOrder = DistributionInstructionTypeCode.GlobalReturnOrder, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction to transfer the position from one sequestered balance (related to a CA option) to another sequestered balalnce (related to another CA option).
    /// Encoded/decoded by serializers as &quot;CHAN&quot;.
    /// </summary>
    [EnumMember(Value = "CHAN")]
    [IsoId("_awnn89p-Ed-ak6NoX_4Aeg_-1264498736")]
    [Description(
        @"Instruction to transfer the position from one sequestered balance (related to a CA option) to another sequestered balalnce (related to another CA option)."
    )]
    OptionChangeOrder = DistributionInstructionTypeCode.OptionChangeOrder, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction to transfer securities from a client sequestered balance back to its available balance.
    /// Encoded/decoded by serializers as &quot;IRET&quot;.
    /// </summary>
    [EnumMember(Value = "IRET")]
    [IsoId("_awnn9Np-Ed-ak6NoX_4Aeg_1772889529")]
    [Description(
        @"Instruction to transfer securities from a client sequestered balance back to its available balance."
    )]
    IndividualReturnOrder = DistributionInstructionTypeCode.IndividualReturnOrder, // same ordinal as derivation source for type conversions
}
