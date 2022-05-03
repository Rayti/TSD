<template>
  <HeaderComponent @emit-event="onReceivedEvent"></HeaderComponent>
  <HelloWorld msg="Hello in books app"/>
  <FooterComponent></FooterComponent>
</template>

<script>
import HelloWorld from './components/HelloWorld.vue'
import FooterComponent from "@/components/FooterComponent";
import HeaderComponent from "@/components/HeaderComponent";

export default {
  name: 'App',
  components: {
    HeaderComponent,
    FooterComponent,
    HelloWorld
  },
  methods: {
    onReceivedEvent(){
      console.log("event")
      alert("Menu Item was clicked")
    }
  }
}
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
}
</style>
