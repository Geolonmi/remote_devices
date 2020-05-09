import { Layout, Menu } from "antd";
import { BulbOutlined } from "@ant-design/icons";
import React from "react";

import "./app.css";

const { Header, Content, Footer, Sider } = Layout;

export class App extends React.Component {
  render() {
    return (
      <Layout>
        <Sider className="sider-full-height">
          <div className="logo" />
          <Menu theme="dark" mode="inline" defaultSelectedKeys={["1"]}>
            <Menu.Item key="1" icon={<BulbOutlined />}>
              Devices
            </Menu.Item>
          </Menu>
        </Sider>
        <Layout className="site-layout">
          <Header className="site-layout-background" style={{ padding: 0 }} />
          <Content style={{ margin: "24px 16px 0", overflow: "initial" }}>
            <div
              className="site-layout-background"
              style={{ padding: 24, textAlign: "center" }}
            >
              My Content
            </div>
          </Content>
          <Footer style={{ textAlign: "center" }}>Remote devices ©2020</Footer>
        </Layout>
      </Layout>
    );
  }
}
