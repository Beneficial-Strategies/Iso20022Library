// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Modality of counting as a predefined or proprietary code value.
    /// </summary>
    [KnownType(typeof(ModalityOfCounting1Choice.Code))]
    [KnownType(typeof(ModalityOfCounting1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(ModalityOfCounting1Choice.Code),
        nameof(ModalityOfCounting1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(ModalityOfCounting1Choice.Proprietary),
        nameof(ModalityOfCounting1Choice.Proprietary)
    )]
    [IsoId("_ZBJPkK-vEemJ1NnLPsTFaw")]
    [DisplayName("Modality Of Counting 1 Choice")]
    public abstract record ModalityOfCounting1Choice_ { }
}
