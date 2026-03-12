// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CommunicationChannel1Choice
{
    /// <summary>
    /// CBRF communication channel mode.
    /// </summary>
    [IsoId("_jLDdcA1DEeazkbJaoKTIIw")]
    [DisplayName("Channel Mode")]
    public partial record ChannelMode : CommunicationChannel1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a numeric string with an exact length of1digit.
        /// </summary>
        [IsoXmlTag("ChanlMd")]
        [IsoSimpleType(IsoSimpleType.Exact1NumericText)]
        public required IsoExact1NumericText Value { get; init; } 
        
        
        #nullable disable
        
    }
}
