// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Amounts;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Codesets;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.Factory;
using BeneficialStrategies.Iso20022.SimpleTypes;

namespace BeneficialStrategies.Iso20022.Samples.ChequeDeliveryMethod1Choice.Valid;

/// <summary>Valid samples of <c>Proprietary</c> of <c>ChequeDeliveryMethod1Choice</c>.</summary>
public static class Proprietary
{
    /// <summary>A valid <c>Proprietary</c> of <c>ChequeDeliveryMethod1Choice</c> with few members set (what the validator tests needed). A new object on every access.</summary>
    public static BeneficialStrategies.Iso20022.Choices.ChequeDeliveryMethod1Choice.IProprietary Minimal =>
        IsoDataFactory.Make<Choices.ChequeDeliveryMethod1Choice.IProprietary>(b => b
                .Set(x => x.Value).To("COURIER"));
}
