// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.EUDividendStatusType1Choice
{
    /// <summary>
    /// Specifies whether dividend is in the scope of the European directive on taxation of savings income in the form of interest payments (Council Directive 2003/48/EC 3 June), or an income realised upon sale, a refund or redemption of shares and units, etc.
    /// </summary>
    [IsoId("_RgcdE9p-Ed-ak6NoX_4Aeg_-780950982")]
    [DisplayName("EU Dividend Status")]
    public partial record EUDividendStatus : EUDividendStatusType1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies whether the dividend is in the scope of the European directive on taxation of savings income in the form of interest payments.
        /// </summary>
        [IsoXmlTag("EUDvddSts")]
        public required EUDividendStatus1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
