import React from 'react';
import { Container, Menu } from 'semantic-ui-react';
import styled from 'styled-components';

export default function NavBar() {

    return (
        <Menu fixed='top'>
            <Container>
                <Menu.Item header>
                    <img src="/assets/logo.png" alt="logo"/>
                </Menu.Item>
                <Menu.Item name="Trips"/>
                <Menu.Item name="Discounts" />
                <Menu.Item name="Sign In" position='right'/>
            </Container>
        </Menu>
    )
}