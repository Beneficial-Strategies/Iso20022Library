namespace BeneficialStrategies.Iso20022.Framework
{
    /// <summary>
    /// To be applied to members of primitive types to identify how formatting and other handling should be done.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class IsoSimpleTypeAttribute : System.Attribute
    {
        /// <summary>
        /// The ISO-specified simple type for this value.
        /// </summary>
        public IsoSimpleType SimpleType { get; }

        /// <summary>
        /// Constructs the attribute as a marker on a member using the specified simple type.
        /// </summary>
        /// <param name="isoSimpleType">ISO20022 simple type for this member.</param>
        public IsoSimpleTypeAttribute(IsoSimpleType isoSimpleType)
        {
            this.SimpleType = isoSimpleType;
        }
    }

    /// <summary>
    /// Identifies the ISO-specified tag that should be applied while serializing this member.
    /// When applied to a class, identifies the XML wrapper element for a complex choice variant
    /// (e.g. <c>[IsoXmlTag("Agt")]</c> on <c>Party40Choice.Agent</c>).
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Class)]
    public class IsoXmlTagAttribute : System.Attribute
    {
        /// <summary>
        /// The ISO20022 xml element name to be used for this member.
        /// </summary>
        public string XmlTag { get; }

        /// <summary>
        /// Constructs the attribute using the specified tag.
        /// </summary>
        /// <param name="xmlTag">ISO20022 xml element name used for this member.</param>
        public IsoXmlTagAttribute(string xmlTag)
        {
            this.XmlTag = xmlTag;
        }
    }
}
