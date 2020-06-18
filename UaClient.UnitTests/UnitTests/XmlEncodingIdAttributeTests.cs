﻿using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using Workstation.ServiceModel.Ua;
using Xunit;

namespace Workstation.UaClient.UnitTests
{
    public class XmlEncodingIdAttributeTests
    {
        public static IEnumerable<object[]> CreateData => ExpandedNodeIdTests.ParseData;

        [MemberData(nameof(CreateData))]
        [Theory]
        public void Create(string s, ExpandedNodeId id)
        {
            var att = new XmlEncodingIdAttribute(s);

            att.NodeId
                .Should().Be(id);
        }
    }
}
