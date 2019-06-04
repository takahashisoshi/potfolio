<?php
/**
 * @var \App\View\AppView $this
 * @var \App\Model\Entity\Finalranking $finalranking
 */
?>
<nav class="large-3 medium-4 columns" id="actions-sidebar">
    <ul class="side-nav">
        <li class="heading"><?= __('Actions') ?></li>
        <li><?= $this->Html->link(__('List Finalranking'), ['action' => 'index']) ?></li>
    </ul>
</nav>
<div class="finalranking form large-9 medium-8 columns content">
    <?= $this->Form->create($finalranking) ?>
    <fieldset>
        <legend><?= __('Add Finalranking') ?></legend>
        <?php
            echo $this->Form->control('Score');
            echo $this->Form->control('Date');
        ?>
    </fieldset>
    <?= $this->Form->button(__('Submit')) ?>
    <?= $this->Form->end() ?>
</div>
