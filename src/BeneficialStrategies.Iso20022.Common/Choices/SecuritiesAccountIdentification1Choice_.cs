// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.SecuritiesAccountIdentification1Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice between one or more selected accounts.</summary>
    [IsoId("_i53AkN-5Ee-Ned3-G07x_A")]
    [DisplayName("Securities Account Identification 1 Choice")]
    [KnownType(typeof(SecuritiesAccountIdentification1Choice.SafekeepingAccount))]
    [KnownType(typeof(SecuritiesAccountIdentification1Choice.BlockChainAddressOrWallet))]
    [JsonDerivedType(typeof(SecuritiesAccountIdentification1Choice.SafekeepingAccount))]
    [JsonDerivedType(typeof(SecuritiesAccountIdentification1Choice.BlockChainAddressOrWallet))]
    public abstract record SecuritiesAccountIdentification1Choice_
    {
    }
}
